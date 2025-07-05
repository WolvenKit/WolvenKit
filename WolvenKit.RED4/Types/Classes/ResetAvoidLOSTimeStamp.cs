using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ResetAvoidLOSTimeStamp : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("onDeactivation")] 
		public CBool OnDeactivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("actionBBoard")] 
		public CWeakHandle<gameIBlackboard> ActionBBoard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public ResetAvoidLOSTimeStamp()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
