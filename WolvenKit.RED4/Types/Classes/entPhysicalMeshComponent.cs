using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entPhysicalMeshComponent : entMeshComponent
	{
		[Ordinal(27)] 
		[RED("visibilityAnimationParam")] 
		public CName VisibilityAnimationParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(28)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetPropertyValue<CEnum<physicsSimulationType>>();
			set => SetPropertyValue<CEnum<physicsSimulationType>>(value);
		}

		[Ordinal(29)] 
		[RED("useResourceSimulationType")] 
		public CBool UseResourceSimulationType
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get => GetPropertyValue<CEnum<physicsFilterDataSource>>();
			set => SetPropertyValue<CEnum<physicsFilterDataSource>>(value);
		}

		[Ordinal(32)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		public entPhysicalMeshComponent()
		{
			SimulationType = Enums.physicsSimulationType.Kinematic;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
