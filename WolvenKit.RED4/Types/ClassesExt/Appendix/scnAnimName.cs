using System.IO;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types;

public partial class scnAnimName : IRedAppendix
{
    // this is a union type in c++
    // CName
    // RidAnimationSRRefId
    // RidAnimationContainerSRRefId
    // DynAnim


    [RED("directName")]
    [REDProperty(IsIgnored = true)]
    public CName DirectName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("refName")]
    [REDProperty(IsIgnored = true)]
    public scnRidAnimationSRRefId RefName
    {
        get => GetPropertyValue<scnRidAnimationSRRefId>();
        set => SetPropertyValue<scnRidAnimationSRRefId>(value);
    }

    [RED("container")]
    [REDProperty(IsIgnored = true)]
    public scnRidAnimationContainerSRRefId Container
    {
        get => GetPropertyValue<scnRidAnimationContainerSRRefId>();
        set => SetPropertyValue<scnRidAnimationContainerSRRefId>(value);
    }

    // struct dynAnim
    [RED("animName")]
    [REDProperty(IsIgnored = true)]
    public CName AnimName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [RED("dynVariable")]
    [REDProperty(IsIgnored = true)]
    public CName DynVariable
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    public void Read(Red4Reader reader, uint size)
    {
        if (Type == Enums.scnAnimNameType.direct)
        {
            DirectName = reader.ReadCName();
        }
        else if (Type == Enums.scnAnimNameType.reference)
        {
            RefName = new();
            RefName.Id = reader.BaseReader.ReadUInt32();
        }
        else if (Type == Enums.scnAnimNameType.container)
        {
            Container = new();
            Container.Id = reader.BaseReader.ReadUInt32();
        }
        else if (Type == Enums.scnAnimNameType.dynamic)
        {
            AnimName = reader.ReadCName();
            DynVariable = reader.ReadCName();
        }
    }

    public void Write(Red4Writer writer)
    {
        if (Type == Enums.scnAnimNameType.direct)
        {
            writer.Write(DirectName);
        }
        else if (Type == Enums.scnAnimNameType.reference)
        {
            writer.Write(RefName.Id);
        }
        else if (Type == Enums.scnAnimNameType.container)
        {
            writer.Write(Container.Id);
        }
        else if (Type == Enums.scnAnimNameType.dynamic)
        {
            writer.Write(AnimName);
            writer.Write(DynVariable);
        }
    }
}