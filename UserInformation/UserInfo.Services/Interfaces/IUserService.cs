using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfo.Shared;

namespace UserInfo.Services.Interfaces
{
    public interface IUserService
    {
        UserModel Get(long id);
        IQueryable<UserModel> GetAll();
        Task AddAsync(UserCreateModel user);
        Task<UserModel> GetAsync(long id);
        Task RemoveAsync(long id);
        Task<bool> UpdateAsync(UserModel user);
    }
}
