using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_FacialMixerSlot : animAnimNode_OnePoseInput
	{
		private CArray<animLookAtAnimationDefinition> _lookAtDefinitions;

		[Ordinal(12)] 
		[RED("lookAtDefinitions")] 
		public CArray<animLookAtAnimationDefinition> LookAtDefinitions
		{
			get => GetProperty(ref _lookAtDefinitions);
			set => SetProperty(ref _lookAtDefinitions, value);
		}
	}
}
