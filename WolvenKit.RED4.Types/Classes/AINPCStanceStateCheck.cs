using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AINPCStanceStateCheck : AINPCStateCheck
	{
		[Ordinal(0)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public AINPCStanceStateCheck()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
