using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipGenerics6NullableStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User()
            {
                UserName = "Andrew",
                Email = "andrew@admin.com",
                Age = null,
                PermissionType = null
            };
            
            if (user.Age.HasValue)
            {
                Console.WriteLine("{0} is {1} years old", user.UserName, user.Age.Value);
            }

        }
    }

    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public Nullable<int> Age { get; set; }
        public int? PermissionType { get; set; }
    }
}
