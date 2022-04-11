using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entGarmentParameterChunkData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("morphOffsetScales")] 
		public CArray<CUInt8> MorphOffsetScales
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(1)] 
		[RED("morphOffsetScalesHash")] 
		public CUInt64 MorphOffsetScalesHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(2)] 
		[RED("visibleTriangleInds")] 
		public CArray<CUInt16> VisibleTriangleInds
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		public entGarmentParameterChunkData()
		{
			MorphOffsetScales = new();
			VisibleTriangleInds = new();
		}
	}
}
