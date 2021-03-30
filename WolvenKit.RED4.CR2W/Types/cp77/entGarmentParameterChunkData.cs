using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entGarmentParameterChunkData : CVariable
	{
		private CArray<CUInt8> _morphOffsetScales;
		private CUInt64 _morphOffsetScalesHash;
		private CArray<CUInt16> _visibleTriangleInds;

		[Ordinal(0)] 
		[RED("morphOffsetScales")] 
		public CArray<CUInt8> MorphOffsetScales
		{
			get => GetProperty(ref _morphOffsetScales);
			set => SetProperty(ref _morphOffsetScales, value);
		}

		[Ordinal(1)] 
		[RED("morphOffsetScalesHash")] 
		public CUInt64 MorphOffsetScalesHash
		{
			get => GetProperty(ref _morphOffsetScalesHash);
			set => SetProperty(ref _morphOffsetScalesHash, value);
		}

		[Ordinal(2)] 
		[RED("visibleTriangleInds")] 
		public CArray<CUInt16> VisibleTriangleInds
		{
			get => GetProperty(ref _visibleTriangleInds);
			set => SetProperty(ref _visibleTriangleInds, value);
		}

		public entGarmentParameterChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
