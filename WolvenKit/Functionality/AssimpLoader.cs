using System;
using System.Windows;
using Assimp;

namespace Ab3d.Assimp
{
    public static class AssimpLoader
    {
        public static void LoadAssimpNativeLibrary()
        {
            // IMPORTANT:

            // To use assimp importer in your project, you need to prepare the native and the managed part of the library.
            //
            // 1) Prepare native assimp libraries
            //
            //    The core part of the assimp importer is its native library that is compiled into two dlls: Assimp32.dll and Assimp64.dll.
            //    One is for x86 application, the other for x64 applications.
            //
            //    The easiest way to to make those two libraries available to your application is to make sure that they are added to the compiler output folder.
            //    This can be done with adding the dlls to the root of your project and in the file properties set the "Copy to Output Directory" to "Copy is newer".
            //
            //    You can also provide the dlls in some other folder. In this case you need to call AssimpWpfImporter.LoadAssimpNativeLibrary method and
            //    in the parameters provide path to x86 and x64 version of the library.
            //
            //    If your project is not compiled for AnyCPU, then you can distribute only the version for your target platform.
            //
            //
            // 2) Ensure that Visual C++ Redistributable for Visual Studio 2015 in available on the system
            //
            //  The native Assimp library requires that the Visual C++ Redistributable for Visual Studio 2015 is available on the system.
            //
            //  Visual C++ Redistributable for Visual Studio 2015 is installed on all Windows 10 systems and should be installed on
            //  all Windows Vista and newer systems that have automatic windows update enabled.
            //  More information about "Distributing Software that uses the Universal CRT" can be read in the following MSDN article: https://blogs.msdn.microsoft.com/vcblog/2015/03/03/introducing-the-universal-crt
            //
            //  If your application is deployed to a system prior to Windows 10 and without installed windows updates,
            //  then you have to provide the required dlls by yourself. You have two options:
            //  a) The recommended way is to Install Visual Studio 2015 VCRedist (redistributable package files) to the target system,
            //  b) It is also possible to copy all required dlls with your application (see 6th point under "Distributing Software that uses the Universal CRT" in the link above).
            //
            //
            // 3) Add reference to managed libraries
            //
            //    After you have the native part set up, then you only need to add reference to:
            //    - Assimp.Net library (AssimpNet.dll file) that provides a managed wrapper for the native addimp library,
            //    - Ab3d.PowerToys.Assimp library (Ab3d.PowerToys.Assimp.dll file) that provides logic to convert assimp objects into WPF 3D objects.



            // In this sample both Assimp32.dll and Assimp64.dll are copied to output directory
            // and can be automatically found when needed.
            //
            // In such case it is not needed to call AssimpWpfImporter.LoadAssimpNativeLibrary as it is done below.
            // Here this is done for cases when there is a problem with loading assimp library because
            // Visual C++ Redistributable for Visual Studio 2015 is not installed on the system - in this case a message box is shown to the user.


            // To provide Assimp32 in its own folder, use the following path:
            //string assimp32Folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assimp32");
            //string assimp64Folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assimp64");

            // Here both Assimp32.dll and Assimp64.dll are available in output directory
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
