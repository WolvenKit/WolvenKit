using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DismembermentTriggeredHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("currValue")] 
		public CUInt32 CurrValue
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public DismembermentTriggeredHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
