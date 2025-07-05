using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AccumulatedDamageDigitsNode : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("used")] 
		public CBool Used
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("controller")] 
		public CWeakHandle<AccumulatedDamageDigitLogicController> Controller
		{
			get => GetPropertyValue<CWeakHandle<AccumulatedDamageDigitLogicController>>();
			set => SetPropertyValue<CWeakHandle<AccumulatedDamageDigitLogicController>>(value);
		}

		[Ordinal(3)] 
		[RED("isDamageOverTime")] 
		public CBool IsDamageOverTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AccumulatedDamageDigitsNode()
		{
			EntityID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
