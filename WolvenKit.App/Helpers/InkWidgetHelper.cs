using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;
public static class InkWidgetHelper
{
    public static bool OnSave(string extStr, ref CR2WFile cr2wFile)
    {
        if (cr2wFile.RootChunk is inkWidgetLibraryResource resource)
        {
            foreach (var item in resource.LibraryItems)
            {
                if (item.Package.Data is CR2WWrapper wrapper)
                {
                    // copy package to packageData
                    item.PackageData = new DataBuffer();
                    item.PackageData.Buffer = new RedBuffer();
                    var package = new RedPackage();
                    package.Chunks = new List<RedBaseClass>() { wrapper.File.RootChunk };
                    item.PackageData.Buffer.Data = package;
                }
            }
        }

        return true;
    }
}
