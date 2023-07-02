using BantuLite.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BantuLite.Service
{
    public class GLService : IGLService
    {
        static IDbConnection _dbcon = DbCon.Connection();

        public Tuple<List<GeneralLedger>, int> GetGeneralLedgers(int? page, int? limit, string filterQuery)
        {
            if (page == 0)
            {
                page = 1;
            }

            List<GeneralLedger> list = new List<GeneralLedger>();
            var RecCount = 0;

            using (var multi = _dbcon.QueryMultiple("p_GetGeneralLedgers",
                new
                {
                    Page = page,
                    Rows = limit,
                    FilterQuery = filterQuery
                }, commandType: CommandType.StoredProcedure))
            {
                RecCount = multi.Read<Int32>().First();
                list = multi.Read<GeneralLedger>().ToList();
            }


            return new Tuple<List<GeneralLedger>, int>(list.ToList(), RecCount);

        }

        public GeneralLedger GetGeneralLedger(string accountID)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@AccountID", accountID);

            var result = _dbcon.Query<GeneralLedger>(
                "p_GetGeneralLedger",
                queryParameters,
                commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }
        public GeneralLedger DisableGL(GeneralLedger generalLedger)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@AccountID", generalLedger.AccountID);
            queryParameters.Add("@OperatorID", generalLedger.OperatorID);
            var result = _dbcon.Query<GeneralLedger>(
                "p_DisableGeneralLedger",
                queryParameters,
                commandType: CommandType.StoredProcedure);
             
            return result.FirstOrDefault();
        }
        public GeneralLedger AddGeneralLedger(GeneralLedger generalLedger)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@BankID", generalLedger.BankID);
            queryParameters.Add("@AccountID", generalLedger.AccountID);
            queryParameters.Add("@Description", generalLedger.Description);
            queryParameters.Add("@ShortName", generalLedger.ShortName);
            queryParameters.Add("@CurrencyID", generalLedger.CurrencyID);
            queryParameters.Add("@GLAccountTypeID", generalLedger.GLAccountTypeID);
            queryParameters.Add("@GLTypeGroupID", generalLedger.GLTypeGroupID);
            queryParameters.Add("@GLSubAccountTypeID", generalLedger.GLSubAccountTypeID);
            queryParameters.Add("@GLCateGoryID", generalLedger.GLCateGoryID);
            queryParameters.Add("@PostingTypeID", generalLedger.PostingTypeID);
            queryParameters.Add("@GLClassID", generalLedger.GLClassID);
            queryParameters.Add("@ContraAccountID", generalLedger.ContraAccountID);
            queryParameters.Add("@MainGLAccountID", generalLedger.MainGLAccountID);
            queryParameters.Add("@IsRevaluate", generalLedger.IsRevaluate);
            queryParameters.Add("@Remarks", generalLedger.Remarks);
            queryParameters.Add("@Clasification1", generalLedger.Clasification1);
            queryParameters.Add("@Clasification2", generalLedger.Clasification2);
            queryParameters.Add("@Clasification3", generalLedger.Clasification3);
            queryParameters.Add("@CreatedBy", generalLedger.CreatedBy);
            //queryParameters.Add("@CreatedOn", generalLedger.CreatedOn);
            queryParameters.Add("@ModifiedBy", generalLedger.ModifiedBy);
            queryParameters.Add("@SupervisedBy", generalLedger.SupervisedBy);
            //queryParameters.Add("@SupervisedOn", generalLedger.SupervisedOn);
            queryParameters.Add("@UpdateCount", generalLedger.UpdateCount);

            var result = _dbcon.Query<GeneralLedger>(
                "sp_AddEditGl",
                queryParameters,
                commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();

        }
        public GeneralLedger EditGeneralLedger(GeneralLedger generalLedger)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@AccountID", generalLedger.AccountID);
            queryParameters.Add("@Description", generalLedger.Description);
            queryParameters.Add("@ShortName", generalLedger.ShortName);
            queryParameters.Add("@CurrencyID", generalLedger.CurrencyID);
            queryParameters.Add("@GLAccountTypeID", generalLedger.GLAccountTypeID);
            queryParameters.Add("@GLTypeGroupID", generalLedger.GLTypeGroupID);
            queryParameters.Add("@GLSubAccountTypeID", generalLedger.GLSubAccountTypeID);
            queryParameters.Add("@GLCateGoryID", generalLedger.GLCateGoryID);
            queryParameters.Add("@PostingTypeID", generalLedger.PostingTypeID);
            queryParameters.Add("@GLClassID", generalLedger.GLClassID);
            queryParameters.Add("@ContraAccountID", generalLedger.ContraAccountID);
            queryParameters.Add("@MainGLAccountID", generalLedger.MainGLAccountID);
            queryParameters.Add("@IsRevaluate", generalLedger.IsRevaluate);
            queryParameters.Add("@Remarks", generalLedger.Remarks);
            queryParameters.Add("@Clasification1", generalLedger.Clasification1);
            queryParameters.Add("@Clasification2", generalLedger.Clasification2);
            queryParameters.Add("@Clasification3", generalLedger.Clasification3);
            queryParameters.Add("@ModifiedBy", generalLedger.ModifiedBy);

            var result = _dbcon.Query<GeneralLedger>(
                "sp_EditGl",
                queryParameters,
                commandType: CommandType.StoredProcedure
                );

            return result.FirstOrDefault();
        }
        //public GeneralLedger SearchColumns(string accountID, string Description, string Shortname, string CurrencyID)
        //{
        //    return 
        //}
            
    }


}
