using DomainModel.Entities;
using DomainModel.Interfaces.Services;
using Data.Repositories;
using DomainServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Interfaces.Repositories;
using Data.Context;
using StorageService;

namespace Application
{
    //Disponibilizar todos os serviços do nosso Domínio.
    public class ApplicationServices
    {
        //Serviço de Domínio
        private IUserServices _userServices;

        //Única instância de "ApplicationServices"
        private static ApplicationServices _instance;
        private static SocialNetworkContext context;

        private ApplicationServices(IUserServices userServices)
        {
            _userServices = userServices;
        }

        //Para poder acessar esse método sem ele ter sido instanciado
        //é necessário que ele seja estático.
        public static ApplicationServices GetInstance()
        {
            if (_instance == null)
            {
                //Pseudo Injeção de Dependência
                context = new SocialNetworkContext();
                IUserRepository userRepository = new UserRepository(context);
                IUserServices userServices = new UserServices(userRepository);
                _instance = new ApplicationServices(userServices);
            }
            return _instance;
        }

        //########### Serviços de Perfil #############
        public void AddNewUser(User user)
        {
            _userServices.CreateUser(user);
            context.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            _userServices.UpdateUser(user);
            context.SaveChanges();
        }
        public void UploadPhoto(User user, System.IO.Stream photo, string contentType)
        {
            string photoUrl = BlobService.GetInstance().UploadFile("bruna", Guid.NewGuid().ToString(), photo, contentType);
            user.PhotoProfile.Url = photoUrl;
            UpdateUser(user);
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _userServices.GetAllUsers();
        }
        //############################################

    }
}
