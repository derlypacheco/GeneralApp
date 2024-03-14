using GeneralApp.Models;
using System.Drawing.Text;

namespace GeneralApp.Repositories
{
    public class UserRepositorie
    {
        public async Task<List<User>> GetUsers()
        {
            //await Task.Delay(1200); // Espera para simular un tiempo en la carga de datos
            User[]? userTemp;
            var dates = DateOnly.FromDateTime(DateTime.Now);
            var names = new[] { "Juan", "María", "Pedro", "Ana", "Luis", "Laura", "Diego", "Sofía", "Carlos", "Elena", "Miguel", "Lucía", "Javier", "Valeria", "Pablo", "Claudia", "Alejandro", "Isabella", "Daniel", "Camila" };
            var lastname = new[] { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson" };
            var images = new[] {
            "https://static.generated.photos/vue-static/face-generator/landing/wall/3.jpg",
            "https://static.generated.photos/vue-static/face-generator/landing/wall/12.jpg",
            "https://static.generated.photos/vue-static/face-generator/landing/wall/10.jpg",
            "https://static.generated.photos/vue-static/face-generator/landing/wall/15.jpg",
            "https://static.generated.photos/vue-static/face-generator/landing/wall/14.jpg",
            "https://static.generated.photos/vue-static/face-generator/landing/wall/1.jpg",
            "https://static.generated.photos/vue-static/face-generator/landing/wall/2.jpg",
            "https://static.generated.photos/vue-static/face-generator/landing/wall/4.jpg",
            "https://static.generated.photos/vue-static/face-generator/landing/wall/5.jpg",
            "https://static.generated.photos/vue-static/face-generator/landing/wall/6.jpg",
            "https://static.generated.photos/vue-static/face-generator/landing/wall/7.jpg",
            };
            var phones = new[] { "1234567890", "2345678901", "3456789012", "4567890123", "5678901234", "6789012345", "7890123456", "8901234567", "9012345678", "0123456789", "1122334455", "2233445566", "3344556677", "4455667788", "5566778899", "6677889900", "7788990011", "8899001122", "9900112233", "0011223344" };
            userTemp = Enumerable.Range(1, 45).Select(i => new User
            {
                Id = i,
                Name = names[Random.Shared.Next(names.Length)],
                Lastname = lastname[Random.Shared.Next(lastname.Length)],
                Email = names[Random.Shared.Next(names.Length)]+"."+ lastname[Random.Shared.Next(lastname.Length)]+"@dominio.com",
                Username = names[Random.Shared.Next(names.Length)] + "." + lastname[Random.Shared.Next(lastname.Length)],
                Image = images[Random.Shared.Next(images.Length)],
                Password = Guid.NewGuid().ToString(),
                PhoneNumber = phones[Random.Shared.Next(phones.Length)]
            }).ToArray();
            return userTemp.ToList();
        }

        public async Task<bool> DeleteUser(User user)
        {
            try
            {
                if (user != null)
                {
                return true;
                } else { return false; }
            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}
