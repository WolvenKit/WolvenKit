using System;
using System.Windows;
using Ab3d.Assimp;
using Assimp;

namespace WolvenKit.Functionality.Ab4d
{
    public static class AssimpLoader
    {
        public static void LoadAssimpNativeLibrary()
        {
            // IMPORTANT:


            //
            // 2) Ensure that Visual C++ Redistributable for Visual Studio 2015 in available on the system
            //

            string assimp32Folder = AppDomain.CurrentDomain.BaseDirectory;
            string assimp64Folder = assimp32Folder;

            try
            {
                AssimpWpfImporter.LoadAssimpNativeLibrary(assimp32Folder, assimp64Folder); // This method can be called multiple times without problems
            }
            catch (AssimpException ex)
            {
                MessageBox.Show(
                @"Error loading native assimp library!

                The most common cause of this error is that the 
                Visual C++ Redistributable for Visual Studio 2015
                is not installed on the system. 

                Please install it manually or contact support of the application.

                Error message:
                " + ex.Message);

                throw;
            }
        }
    }
}
