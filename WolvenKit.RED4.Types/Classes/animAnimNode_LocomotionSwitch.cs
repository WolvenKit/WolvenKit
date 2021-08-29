using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_LocomotionSwitch : animAnimNode_Switch
	{
		private CArray<CName> _audioTagsPerInput;

		[Ordinal(20)] 
		[RED("audioTagsPerInput")] 
		public CArray<CName> AudioTagsPerInput
		{
			get => GetProperty(ref _audioTagsPerInput);
			set => SetProperty(ref _audioTagsPerInput, value);
		}
	}
}
