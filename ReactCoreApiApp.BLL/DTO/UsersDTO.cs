using System;
using System.Collections.Generic;
using System.Text;

namespace ReactCoreApiApp.BLL.DTO
{
    public class UsersDTO
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Role { get; set; }
    }
}
