using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using LocalDataSample.Models;
using Xamarin.Essentials;

namespace LocalDataSample.ViewModels
{
    public class FoldersViewModel : BaseViewModel
    {
        public ObservableCollection<Folder> Folders { get; } =
            new ObservableCollection<Folder>();


        public void OnAppearing()
        {
            InitializeFolderCollection();
        }

        private void InitializeFolderCollection()
        {
            try
            {
                IsBusy = true;
                Folders.Clear();
                Folders.Add(new Folder("Xamarin.Essentials AppDataDirectory", FileSystem.AppDataDirectory));
                Folders.Add(new Folder("Xamarin.Essentials CacheDirectory", FileSystem.CacheDirectory));

                foreach (var folder in Enum.GetValues(typeof(Environment.SpecialFolder)))
                {
                    var folderPath = Environment.GetFolderPath((Environment.SpecialFolder) folder);
                    if (!string.IsNullOrEmpty(folderPath))
                    {
                        Folders.Add(new Folder(folder.ToString(), folderPath));
                    }
                }

            }
            finally
            {
                IsBusy = false;
            }


        }
    }
}
