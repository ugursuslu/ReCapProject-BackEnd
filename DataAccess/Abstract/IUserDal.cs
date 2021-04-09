using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<UserDTO> GetUserDetails();
        List<Core.Entities.Concrete.OperationClaim> GetClaims(User user);
    }
}
