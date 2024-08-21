using P6Answers_APP_MiguelCastro.Models;
using P6Answers_APP_MiguelCastro.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P6Answers_APP_MiguelCastro.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public User MyUser { get; set; }

        public ICommand IngresarCommand { get; }

        public UserViewModel()
        {
            MyUser = new User();
            IngresarCommand = new Command(async () => await Ingresar());
        }
        public static class GlobalUser
        {
            public static User CurrentUser { get; set; }
        }



        public async Task<List<User>?> VmGetUserAsync()
        {
            try
            {
                List<User>? user = new List<User>();

                user = await MyUser.GetUserAsync(4);

                if (user == null) return null;
                return user;


            }
            catch (Exception)
            {

                throw;
            }

        }



        public async Task Ingresar()
        {

            try
            {
                // ID de usuario fijo para la consulta
                const int fixedUserId = 4;

                // Llamar a la función para consultar el usuario
                var user = await MyUser.GetUserAsync(fixedUserId);

                await Application.Current.MainPage.Navigation.PushAsync(new PreguntaPage());
                //// Navegar a PreguntaPage
            }
            catch (Exception)
            {

                // Mostrar mensaje de error
                await Application.Current.MainPage.DisplayAlert("Error", "Usuario no encontrado", "OK");
            }  
             
        }


    }
}
