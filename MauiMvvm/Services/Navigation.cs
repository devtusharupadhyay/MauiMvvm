using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvm.Services
{
    public class Navigation : MauiMvvmLibrary.INavigation
    {
        public required string Namespace { get; set; }

        public void PopAsync()
        {
            App.Current.MainPage.Navigation.PopAsync();
        }

        public async void PushAsync(string pageName)
        {
            var fullyQualifiedName = $"{Namespace}.{pageName}";
            Type type = Type.GetType(fullyQualifiedName) ?? throw new Exception("Invalid assembly or page name. Please provide current page name.");
            var page = Activator.CreateInstance(type);
            await App.Current.MainPage.Navigation.PushAsync((Page)page);

        }
    }
}
