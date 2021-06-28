using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoadEditorDecorationSettings : CVariable
	{
		private CName _libraryName;
		private CFloat _offset;
		private CUInt32 _repeatPatternDensity;
		private CUInt32 _repeatPatternStartOffset;

		[Ordinal(0)] 
		[RED("libraryName")] 
		public CName LibraryName
		{
			get => GetProperty(ref _libraryName);
			set => SetProperty(ref _libraryName, value);
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(2)] 
		[RED("repeatPatternDensity")] 
		public CUInt32 RepeatPatternDensity
		{
			get => GetProperty(ref _repeatPatternDensity);
			set => SetProperty(ref _repeatPatternDensity, value);
		}

		[Ordinal(3)] 
		[RED("repeatPatternStartOffset")] 
		public CUInt32 RepeatPatternStartOffset
		{
			get => GetProperty(ref _repeatPatternStartOffset);
			set => SetProperty(ref _repeatPatternStartOffset, value);
		}

		public gameuiRoadEditorDecorationSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
