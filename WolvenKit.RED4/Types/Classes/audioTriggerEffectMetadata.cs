using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioTriggerEffectMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<audioTriggerEffectMode> Mode
		{
			get => GetPropertyValue<CEnum<audioTriggerEffectMode>>();
			set => SetPropertyValue<CEnum<audioTriggerEffectMode>>(value);
		}

		[Ordinal(2)] 
		[RED("target")] 
		public CEnum<audioTriggerEffectTarget> Target
		{
			get => GetPropertyValue<CEnum<audioTriggerEffectTarget>>();
			set => SetPropertyValue<CEnum<audioTriggerEffectTarget>>(value);
		}

		[Ordinal(3)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("startPosition")] 
		public CFloat StartPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("endPosition")] 
		public CFloat EndPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("frequency")] 
		public CFloat Frequency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioTriggerEffectMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
