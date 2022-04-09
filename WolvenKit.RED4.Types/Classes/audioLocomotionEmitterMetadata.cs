using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioLocomotionEmitterMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("customMaterialLookup")] 
		public CName CustomMaterialLookup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioLocomotionEmitterMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
