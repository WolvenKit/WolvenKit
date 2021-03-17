using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entGarmentParameterChunkData : CVariable
	{
		private CArray<CUInt8> _morphOffsetScales;
		private CArray<CUInt16> _visibleTriangleInds;

		[Ordinal(0)] 
		[RED("morphOffsetScales")] 
		public CArray<CUInt8> MorphOffsetScales
		{
			get => GetProperty(ref _morphOffsetScales);
			set => SetProperty(ref _morphOffsetScales, value);
		}

		[Ordinal(1)] 
		[RED("visibleTriangleInds")] 
		public CArray<CUInt16> VisibleTriangleInds
		{
			get => GetProperty(ref _visibleTriangleInds);
			set => SetProperty(ref _visibleTriangleInds, value);
		}

		public entGarmentParameterChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
