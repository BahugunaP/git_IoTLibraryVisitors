using Entities;
using IoTSolutionsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTSolutionsBAL
{
    public class UserOperationsBAL
    {
        public UserOperationsBAL()
        {

        }
        public virtual bool IsUserExists(int userID)
        {
            return true;
        }
        public void InsertUser(UserDetail userDetails)
        {
            if (IsUserExists(userDetails.UserId))
            {
                UserOperationsDAL userOperations = new UserOperationsDAL();
                userOperations.InsertUser(userDetails);
            }
        }
        public void UpdateUser(UserDetail userDetails)
        {
            if (IsUserExists(userDetails.UserId))
            {
                UserOperationsDAL userOperations = new UserOperationsDAL();
                userOperations.UpdateUser(userDetails);
            }
        }
        public void DeleteUser(UserDetail userDetails)
        {
            if (IsUserExists(userDetails.UserId))
            {
                UserOperationsDAL userOperations = new UserOperationsDAL();
                userOperations.DeleteUser(userDetails);
            }
        }
        public void GetUser(string email)
        {
                UserOperationsDAL userOperations = new UserOperationsDAL();
                userOperations.GetUser(email);
        }
    }
}
