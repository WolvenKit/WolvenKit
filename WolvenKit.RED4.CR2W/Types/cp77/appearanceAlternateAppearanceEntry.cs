using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceAlternateAppearanceEntry : CVariable
	{
		private CName _original;
		private CName _alternate;
		private CUInt8 _alternateAppearanceIndex;

		[Ordinal(0)] 
		[RED("Original")] 
		public CName Original
		{
			get => GetProperty(ref _original);
			set => SetProperty(ref _original, value);
		}

		[Ordinal(1)] 
		[RED("Alternate")] 
		public CName Alternate
		{
			get => GetProperty(ref _alternate);
			set => SetProperty(ref _alternate, value);
		}

		[Ordinal(2)] 
		[RED("AlternateAppearanceIndex")] 
		public CUInt8 AlternateAppearanceIndex
		{
			get => GetProperty(ref _alternateAppearanceIndex);
			set => SetProperty(ref _alternateAppearanceIndex, value);
		}

		public appearanceAlternateAppearanceEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
