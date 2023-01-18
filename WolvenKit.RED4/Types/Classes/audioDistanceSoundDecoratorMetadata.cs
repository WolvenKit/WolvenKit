using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioDistanceSoundDecoratorMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("onEnter")] 
		public CName OnEnter
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("onLeave")] 
		public CName OnLeave
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("triggerDistance")] 
		public CFloat TriggerDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("stopOnlyVirtualSounds")] 
		public CBool StopOnlyVirtualSounds
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioDistanceSoundDecoratorMetadata()
		{
			TriggerDistance = 10.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
