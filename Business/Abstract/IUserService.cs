using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetUsersById(int userId);
        IDataResult<List<UserDTO>> GetUserDetail();
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        List<OperationClaim> GetClaims(User user);         
        User GetByMail(string email);

    }
}
