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
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
