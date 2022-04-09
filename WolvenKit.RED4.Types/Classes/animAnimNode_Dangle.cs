using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Dangle : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("dangleConstraint")] 
		public CHandle<animDangleConstraint_Simulation> DangleConstraint
		{
			get => GetPropertyValue<CHandle<animDangleConstraint_Simulation>>();
			set => SetPropertyValue<CHandle<animDangleConstraint_Simulation>>(value);
		}

		public animAnimNode_Dangle()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
