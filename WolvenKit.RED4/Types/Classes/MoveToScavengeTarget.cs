using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MoveToScavengeTarget : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("lastTime")] 
		public CFloat LastTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("timeoutDuration")] 
		public CFloat TimeoutDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public MoveToScavengeTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
