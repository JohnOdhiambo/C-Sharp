using BantuLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BantuLite.Service
{
    public interface ISecurityService
    {
        IEnumerable<SystemBranch> GetSystemBranches(string bankId);

        IEnumerable<SystemBranch> GetSODDate(string branchId);

        IEnumerable<GeneralLedger> GetGeneralLedgers();

        IEnumerable<GLSubType> GetGLSubType(int bankId);

        string VerifyUserDetails(string username, string pass);

        string GetBankName();

        IEnumerable<SystemBranchStatus> GetSystemBranchStatus();

        string GetSystemMenusJson(string BankID, string BranchID, string Operator);

    }
}
