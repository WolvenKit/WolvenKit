using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class CGIDataBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CUInt32 Uk1 { get; set; }

    public CUInt32 Uk2 { get; set; }

    public CUInt32 Uk3 { get; set; }

    public CUInt32 Uk4 { get; set; }

    public CUInt32 Uk5 { get; set; }

    public CUInt32 Uk6 { get; set; }

    public Box Bounds { get; set; } = new();

    public CArray<CGIBrck> Brcks { get; set; } = new();

    public CArray<CGISurf> Surfs { get; set; } = new();

    public CArray<CColor> Colors { get; set; } = new();

    public CArray<CArray<CGIUkBrckItem>> UkBrckItems { get; set; } = new();

    public CArray<CArray<CGIUkColorItem>> UkColorItems { get; set; } = new();

    public CArray<CGIProb> Probs { get; set; } = new();

    public CArray<CGIFact> Facts { get; set; } = new();

    public CArray<CGITetr> Tetrs { get; set; } = new();

    public CArray<CGIVolt> Volts { get; set; } = new();
}

public class CGIBrck : IRedType
{
    public CUInt32 Offset { get; set; }

    public CUInt16 Length { get; set; }

    public CUInt8 Uk1 { get; set; }

    public CUInt8 Uk2 { get; set; }

    public CUInt8 Uk3 { get; set; }

    public CUInt8 Uk4 { get; set; }
}

public class CGISurf : IRedType
{
    public CUInt16 Uk1 { get; set; }

    public CUInt8 Uk2 { get; set; }

    public CUInt8 Uk3 { get; set; }
}

public class CGIUkBrckItem : IRedType
{
    public CUInt8 Uk1 { get; set; }

    public CUInt8 Uk2 { get; set; }

    public CUInt8 Uk3 { get; set; }
}

public class CGIUkColorItem : IRedType
{
    public CUInt16 Uk1 { get; set; }

    public CUInt8 Uk2 { get; set; }

    public CUInt8 Uk3 { get; set; }
}

public class CGIProb : IRedType
{
    public CUInt16 Uk1 { get; set; }

    public CUInt16 Uk2 { get; set; }

    public CUInt16 Uk3 { get; set; }

    public CUInt16 Uk4 { get; set; }

    public CUInt16 Uk5 { get; set; }

    public CUInt16 Uk6 { get; set; }

    public CUInt16 Uk7 { get; set; }

    public CUInt16 Uk8 { get; set; }

    public CUInt16 Uk9 { get; set; }

    public CUInt16 Uk10 { get; set; }

    public CUInt16 Uk11 { get; set; }

    public CUInt16 Uk12 { get; set; }

    public CUInt16 Uk13 { get; set; }

    public CUInt16 Uk14 { get; set; }

    public CUInt16 Uk15 { get; set; }

    public CUInt16 Uk16 { get; set; }

    public CUInt64 Uk17 { get; set; }

    public CUInt32 Uk18 { get; set; }
}

public class CGIFact : IRedType
{
    public CUInt16 Uk1 { get; set; }

    public CUInt8 Uk2 { get; set; }

    public CUInt8 Uk3 { get; set; }
}

public class CGITetr : IRedType
{
    public CArray<CInt64> Masks { get; set; } = new();

    public CInt16 Uk1 { get; set; }

    public CInt16 Uk2 { get; set; }

    public CInt16 Uk3 { get; set; }

    public CInt16 Uk4 { get; set; }

    public CInt32 Uk5 { get; set; }

    public CInt32 Uk6 { get; set; }

    public CInt32 Uk7 { get; set; }

    public CInt32 Uk8 { get; set; }
}

public class CGIVolt : IRedType
{
    public CUInt32 Uk1 { get; set; }

    public CUInt32 Uk2 { get; set; }
}