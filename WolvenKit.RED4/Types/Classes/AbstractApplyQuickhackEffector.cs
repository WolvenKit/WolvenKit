using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class AbstractApplyQuickhackEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(1)] 
		[RED("applyQuickhackDelayConst")] 
		public CFloat ApplyQuickhackDelayConst
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AbstractApplyQuickhackEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
