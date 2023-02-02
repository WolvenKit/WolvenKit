using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entPhysicalSkinnedMeshComponent : entSkinnedMeshComponent
	{
		[Ordinal(25)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetPropertyValue<CEnum<physicsSimulationType>>();
			set => SetPropertyValue<CEnum<physicsSimulationType>>(value);
		}

		[Ordinal(26)] 
		[RED("useResourceSimulationType")] 
		public CBool UseResourceSimulationType
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get => GetPropertyValue<CEnum<physicsFilterDataSource>>();
			set => SetPropertyValue<CEnum<physicsFilterDataSource>>(value);
		}

		[Ordinal(29)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		public entPhysicalSkinnedMeshComponent()
		{
			SimulationType = Enums.physicsSimulationType.Kinematic;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
