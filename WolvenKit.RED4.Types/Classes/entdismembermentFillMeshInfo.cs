using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentFillMeshInfo : entdismembermentMeshInfo
	{
		[Ordinal(10)] 
		[RED("Placement")] 
		public CBitField<entdismembermentPlacementE> Placement
		{
			get => GetPropertyValue<CBitField<entdismembermentPlacementE>>();
			set => SetPropertyValue<CBitField<entdismembermentPlacementE>>(value);
		}

		[Ordinal(11)] 
		[RED("Simulation")] 
		public CEnum<entdismembermentSimulationTypeE> Simulation
		{
			get => GetPropertyValue<CEnum<entdismembermentSimulationTypeE>>();
			set => SetPropertyValue<CEnum<entdismembermentSimulationTypeE>>(value);
		}

		[Ordinal(12)] 
		[RED("Dangle")] 
		public entdismembermentDangleInfo Dangle
		{
			get => GetPropertyValue<entdismembermentDangleInfo>();
			set => SetPropertyValue<entdismembermentDangleInfo>(value);
		}

		public entdismembermentFillMeshInfo()
		{
			Placement = Enums.entdismembermentPlacementE.MAIN_MESH;
			Dangle = new() { DangleSegmentLenght = 0.100000F, DangleVelocityDamping = 0.400000F, DangleBendStiffness = 0.600000F, DangleCollisionSphereRadius = 0.250000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
