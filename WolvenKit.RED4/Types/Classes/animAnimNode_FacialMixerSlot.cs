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
			Id = 4294967295;
			InputLink = new();
			LookAtDefinitions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
