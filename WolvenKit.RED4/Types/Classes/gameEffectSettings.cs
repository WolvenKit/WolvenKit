using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("advancedTargetHandling")] 
		public CBool AdvancedTargetHandling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("synchronousProcessingForPlayer")] 
		public CBool SynchronousProcessingForPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("forceSynchronousProcessing")] 
		public CBool ForceSynchronousProcessing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("tempExecuteOnlyOnce")] 
		public CBool TempExecuteOnlyOnce
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("tickRate")] 
		public CFloat TickRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("useSimTimeForTick")] 
		public CBool UseSimTimeForTick
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
