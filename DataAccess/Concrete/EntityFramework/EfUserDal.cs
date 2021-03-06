using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<UserDTO> GetUserDetails()
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from user in context.Users
                             join customer in context.Customers
                             on user.Id equals customer.UserId
                             select new UserDTO { FirstName = user.FirstName, LastName = user.LastName, CompanyName = customer.CompanyName };
                return result.ToList();

            }

        }
               
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                var result = from operationClaim in context.OperationClaims
                                join userOperationClaim in context.UserOperationClaims
                                    on operationClaim.Id equals userOperationClaim.OperationClaimId
                                where userOperationClaim.UserId == user.Id
                                select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
        


    }
}
