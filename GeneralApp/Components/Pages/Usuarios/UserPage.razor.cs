using GeneralApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Radzen;
using Radzen.Blazor;
using System.Diagnostics;

namespace GeneralApp.Components.Pages.Usuarios
{
    public partial class UserPage
    {
        List<User> listUsers = new();
        RadzenDataGrid<User>? grid;
        IEnumerable<int> pageSizeOptions = new int[] { 10, 20, 30, 50, 100, 150, 200 };
        bool isLoading = false;

        protected override async Task OnInitializedAsync()
        {
            isLoading = true;
            listUsers = await userRepo.GetUsers();
            isLoading = false;
        }

        public async Task EditUser(User user)
        {
           var result = await DialogService.OpenAsync<UserForm>("Editar usuario",
               new Dictionary<string, object>() { { "user", user } },
               new DialogOptions() { Width = "600px", Resizable = false, Draggable = true, CloseDialogOnEsc = false });
        }

        public async Task AddUser()
        {
            User user = new();
            var dialog = await DialogService.OpenAsync<UserForm>("Agregar nuevo usuario",
                new Dictionary<string, object>() { { "user", user } },
                new DialogOptions() { Width="600px", Resizable=false, Draggable=false, CloseDialogOnEsc=false}); 
            
        }

        public async Task DeleteUser(User user)
        {
            var confirm = await DialogService.Confirm("¿Está seguro de que desea eliminar el usuario?", "Eliminar", new ConfirmOptions() { OkButtonText="Si", CancelButtonText="No" });
            if (confirm.Value == true)
            {
                bool request = await userRepo.DeleteUser(user);
                if (request == true)
                {
                    await DialogService.Alert("El usuario se ha eliminado correctamente", "Eliminar");
                }
                else
                {
                    await DialogService.Alert("Hay un error al eliminar el usuario, intente m�s tarde", "Eliminar");
                }
            }
        }

        public async Task ChangeImage(InputFileChangeEventArgs arg){
            //
        }
    }
}