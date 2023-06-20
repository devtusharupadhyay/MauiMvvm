using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvmLibrary
{
    public interface INavigation
    {
        public string Namespace { get; set; }

        void PushAsync(string pageName);

        void PopAsync();
    }
}
