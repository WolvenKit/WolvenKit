using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FacialMixerSlot : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("lookAtDefinitions")] 
		public CArray<animLookAtAnimationDefinition> LookAtDefinitions
		{
			get => GetPropertyValue<CArray<animLookAtAnimationDefinition>>();
			set => SetPropertyValue<CArray<animLookAtAnimationDefinition>>(value);
		}

		public animAnimNode_FacialMixerSlot()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			LookAtDefinitions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
