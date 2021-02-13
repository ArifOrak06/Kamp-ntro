using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        // Doğrulama servisimizi yani IUserValidationService'i constructor olarak başlattık.Newleme aşamasında doğrulama servisinin başlaması gerekir.
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " isimli kulanıcının doğrulaması başarılı bir şekilde yapılarak sisteme kayıt olmuştur.");
            }
            else
            {
                Console.WriteLine("Sisteme Kaydınız yapılamamıştır.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
