using GameManagementProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementProject.Entities
{
    class Player:IPlayerService
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public string NationalityId { get; set; }


    }
}
