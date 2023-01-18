using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.RED4.Types;

public partial class meshMeshMaterialBuffer
{
    [RED("materials")]
    [REDProperty(IsIgnored = true)]
    public CArray<IMaterial> Materials
    {
        get => GetPropertyValue<CArray<IMaterial>>();
        set => SetPropertyValue<CArray<IMaterial>>(value);
    }
}