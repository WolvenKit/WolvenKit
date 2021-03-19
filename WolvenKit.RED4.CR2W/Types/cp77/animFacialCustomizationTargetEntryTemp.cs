using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialCustomizationTargetEntryTemp : CVariable
	{
		private raRef<animFacialSetup> _setup;
		private CArray<CName> _targetNames;

		[Ordinal(0)] 
		[RED("setup")] 
		public raRef<animFacialSetup> Setup
		{
			get => GetProperty(ref _setup);
			set => SetProperty(ref _setup, value);
		}

		[Ordinal(1)] 
		[RED("targetNames")] 
		public CArray<CName> TargetNames
		{
			get => GetProperty(ref _targetNames);
			set => SetProperty(ref _targetNames, value);
		}

		public animFacialCustomizationTargetEntryTemp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
