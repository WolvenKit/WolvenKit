using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioBreathingTemporaryStateMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("inhaleSound")] 
		public CName InhaleSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("exhaleSound")] 
		public CName ExhaleSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("paramChangeSpeed")] 
		public CFloat ParamChangeSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("targetBpm")] 
		public CFloat TargetBpm
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("targetTimeDistortion")] 
		public CFloat TargetTimeDistortion
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("exhaustionChangeSpeed")] 
		public CFloat ExhaustionChangeSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("targetExhaustion")] 
		public CFloat TargetExhaustion
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("loopBehavior")] 
		public CEnum<audiobreathingLoopBehavior> LoopBehavior
		{
			get => GetPropertyValue<CEnum<audiobreathingLoopBehavior>>();
			set => SetPropertyValue<CEnum<audiobreathingLoopBehavior>>(value);
		}

		[Ordinal(10)] 
		[RED("startStateFromBreath")] 
		public CBool StartStateFromBreath
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioBreathingTemporaryStateMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
