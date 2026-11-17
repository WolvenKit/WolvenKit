using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ORHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("conditions")] 
		public CArray<CHandle<BaseHitPrereqCondition>> Conditions
		{
			get => GetPropertyValue<CArray<CHandle<BaseHitPrereqCondition>>>();
			set => SetPropertyValue<CArray<CHandle<BaseHitPrereqCondition>>>(value);
		}

		public ORHitPrereqCondition()
		{
			Conditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
