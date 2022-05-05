using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_Interaction : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("interactionDuration")] 
		public CFloat InteractionDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("interactionStage")] 
		public CInt32 InteractionStage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animAnimFeature_Interaction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
