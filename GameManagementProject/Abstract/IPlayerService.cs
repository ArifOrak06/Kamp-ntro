using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementProject.Abstract
{
    interface IPlayerService
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string NationalityId { get; set; }
        int YearOfBirth { get; set; }

    }
}
