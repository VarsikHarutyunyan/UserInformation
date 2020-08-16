using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfo.Data.Entities;
using UserInfo.Data.Repository.Interfaces;
using UserInfo.Services.Interfaces;
using UserInfo.Shared;

namespace UserInfo.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _user;
        private readonly IMapper _mapper;
        public UserService(IGenericRepository<User> user, IMapper mapper)
        {
            _user = user;
            _mapper = mapper;
        }

        public async Task AddAsync(UserCreateModel userModel)
        {
            var user = _mapper.Map<User>(userModel);
            await _user.InsertAsync(user);
            await _user.SaveAsync();

        }
        public async Task<UserModel> GetAsync(long id)
        {
            var userModel = await _user.GetByIdAsync(id);
            if (userModel == null)
            {
                return null;
            }

            var user = _mapper.Map<UserModel>(userModel);
            return user;
        }

        public async Task RemoveAsync(long id)
        {
            await _user.DeleteAsync(id); ;
            await _user.SaveAsync();
        }

        public async Task<bool> UpdateAsync(UserModel userModel)
        {
            var user = await _user.GetByIdAsync(userModel.Id);

            if (user == null)
                return false;

            user.Name = userModel.Name;
            user.Surname = userModel.Surname;
            user.FatherInfo = userModel.FatherInfo;
            user.MotherInfo = userModel.MotherInfo;

            await _user.UpdateAsync(user);
            await _user.SaveAsync();
            return true;
        }

        public UserModel Get(long id)
        {
            var userModel = _user.GetById(id);
            if (userModel == null)
            {
                return null;
            }

            var user = _mapper.Map<UserModel>(userModel);
            return user;
        }

        public IQueryable<UserModel> GetAll()
        {
            var users = _user.GetAll();

            if (users == null)
                return null;

            var user = (from item in users

                        select new UserModel
                        {
                            Id = item.Id,
                            Name = item.Name,
                            Surname = item.Surname,
                            FatherInfo = item.FatherInfo,
                            MotherInfo = item.MotherInfo
                        }).AsQueryable();

            return user;
        }
    }
}
