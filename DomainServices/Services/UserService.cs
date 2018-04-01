using DomainModel.Interfaces.Services;
using System.Collections.Generic;
using DomainModel.Entities;
using Data.Repositories;
using DomainModel.Interfaces.Repositories;

namespace DomainServices.Services
{

    public class UserServices : IUserServices
    {

        private IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(User user)
        {
            _userRepository.Add(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }
    }
}
