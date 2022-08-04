﻿using Microsoft.AspNetCore.Identity;
using UserControl.Models;

namespace UserControl.Data
{
    public class Users : IUsers
    {
        #region Constructor
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly DateTime EndDate;
        public Users(UserManager<ApplicationUser> userMgr)
        {
            EndDate = new DateTime(2222, 06, 06);

            _userManager = userMgr;
        }
        #endregion
        public bool LockUser(string email, DateTime? endDate)
        {
            if (endDate == null)
                endDate = EndDate;

            var userTask = _userManager.FindByIdAsync(email);
            userTask.Wait();
            var user = userTask.Result;

            var lockUserTask = _userManager.SetLockoutEnabledAsync(user, true);
            lockUserTask.Wait();

            var lockDateTask = _userManager.SetLockoutEndDateAsync(user, endDate);
            lockDateTask.Wait();

            return lockDateTask.Result.Succeeded && lockUserTask.Result.Succeeded;
        }

        public bool UnlockUser(string email)
        {
            var userTask = _userManager.FindByIdAsync(email);
            userTask.Wait();
            var user = userTask.Result;

            var lockDisabledTask = _userManager.SetLockoutEnabledAsync(user, false);
            lockDisabledTask.Wait();

            var setLockoutEndDateTask = _userManager.SetLockoutEndDateAsync(user, DateTime.Now - TimeSpan.FromMinutes(1));
            setLockoutEndDateTask.Wait();

            return setLockoutEndDateTask.Result.Succeeded && lockDisabledTask.Result.Succeeded;
        }
    }
}
