using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionSwitch : animAnimNode_Switch
	{
		private CArray<CName> _audioTagsPerInput;

		[Ordinal(20)] 
		[RED("audioTagsPerInput")] 
		public CArray<CName> AudioTagsPerInput
		{
			get => GetProperty(ref _audioTagsPerInput);
			set => SetProperty(ref _audioTagsPerInput, value);
		}

		public animAnimNode_LocomotionSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
