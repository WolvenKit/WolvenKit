using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LeaveCoverImmediately : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("completeOnLeave")] 
		public CBool CompleteOnLeave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("timeStamp")] 
		public CFloat TimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("triggered")] 
		public CBool Triggered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LeaveCoverImmediately()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
