using System;
using System.Windows;
using Ab3d.Assimp;
using Assimp;

namespace WolvenKit.Functionality.Helpers
{
    public static partial class Helpers
    {
        // load assimp libraries.
        public static void LoadAssimpNativeLibrary()
        {
            var assimp32Folder = AppDomain.CurrentDomain.BaseDirectory;
            var assimp64Folder = assimp32Folder;
            try
            { AssimpWpfImporter.LoadAssimpNativeLibrary(assimp32Folder, assimp64Folder); }
            catch (AssimpException ex)
            {
                MessageBox.Show(
                @"Error loading native assimp library!

                The most common cause of this error is that the 
                Visual C++ Redistributable for Visual Studio 2015
                is not installed on the system. 

                Please install it manually or contact support of the application.

                Error message: " + ex.Message);
                throw;
            }
        }
    }
}
