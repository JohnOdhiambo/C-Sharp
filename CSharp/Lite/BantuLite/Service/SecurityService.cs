using BantuLite.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BantuLite.Service
{
    public class SecurityService : ISecurityService
    {
        IDbConnection _dbcon = DbCon.Connection();
        //IDbConnection con = DbInstance.GetInstance();
        private readonly IConfiguration _config;

        public SecurityService(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("CBS"));
            }
        }


        public IEnumerable<SystemBranch> GetSystemBranches(string bankId)
        {
            using (_dbcon)
            {
                var result = _dbcon.Query<SystemBranch>("p_GetSystemBranch", new
                {
                    BankID = bankId
                }, null, true, 0, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public IEnumerable<SystemBranchStatus> GetSystemBranchStatus()
        {
            //using (_dbcon)
            //{
            //    var parameters = new DynamicParameters();
            //    var res = this.ExecuteSP<dynamic>("pc_SystemBranchStatus");
            //    return ToDataTable(res);
            //}

            using (IDbConnection _dbcon = DbCon.Connection())
            {
                var result = _dbcon.Query<SystemBranchStatus>("pc_SystemBranchStatus", null,
                    null, true, 0, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public IEnumerable<SystemBranch> GetSODDate(string branchId)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@BRANCHID", branchId);

            var result = _dbcon.Query<SystemBranch>(
                "sp_GetSODDateBranchName",
                queryParameters,
                commandType: CommandType.StoredProcedure);

            return result;
        }

        public IEnumerable<GeneralLedger> GetGeneralLedgers()
        {
            var result = _dbcon.Query<GeneralLedger>("p_GetGeneralLedgers", commandType: CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<GLSubType> GetGLSubType(int bankId = 12)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@BankID", bankId);

            var result = _dbcon.Query<GLSubType>("p_GetGLSubTypeCombo",
                queryParameters, commandType: CommandType.StoredProcedure);
            return result;
        }

        public string VerifyUserDetails(string username, string pass)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@OPERATORID", username);

            var result = _dbcon.Query<string>(
                "sp_GetUserPassword",
                queryParameters,
                commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public string GetBankName()
        {
            var result = _dbcon.Query<string>(
                "GetBankName",
                null,
                commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public string GetSystemMenusJson(string BankID, string BranchID, string Operator)
        {
            var result = _dbcon.Query<string>("p_getMenu_New", new
            {
                BankID = "12",
                OurBranchID = "00",
                OperatorID = "BANTU"
            },
            null, true, 0, commandType: CommandType.StoredProcedure).SingleOrDefault();

            return result.ToString();
        }

        public virtual IEnumerable<TEntity> ExecuteSP<TEntity>(string spName, object parameters = null)
        {
            using (IDbConnection conn = Connection)
            {
                conn.Open();
                return conn.Query<TEntity>(spName, parameters, commandTimeout: 0, commandType: CommandType.StoredProcedure);
            }
        }

        public DataTable ToDataTable(IEnumerable<dynamic> items)
        {
            if (items == null) return null;
            var data = items.ToArray();
            if (data.Length == 0) return null;

            var dt = new DataTable();
            foreach (var pair in ((IDictionary<string, object>)data[0]))
            {
                dt.Columns.Add(pair.Key, (pair.Value ?? string.Empty).GetType());
            }
            foreach (var d in data)
            {
                dt.Rows.Add(((IDictionary<string, object>)d).Values.ToArray());
            }
            return dt;
        }
    }

}
