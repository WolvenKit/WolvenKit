using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entPhysicalMeshComponent : entMeshComponent
	{
		private CName _visibilityAnimationParam;
		private CEnum<physicsSimulationType> _simulationType;
		private CBool _useResourceSimulationType;
		private CBool _startInactive;
		private CEnum<physicsFilterDataSource> _filterDataSource;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(24)] 
		[RED("visibilityAnimationParam")] 
		public CName VisibilityAnimationParam
		{
			get => GetProperty(ref _visibilityAnimationParam);
			set => SetProperty(ref _visibilityAnimationParam, value);
		}

		[Ordinal(25)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetProperty(ref _simulationType);
			set => SetProperty(ref _simulationType, value);
		}

		[Ordinal(26)] 
		[RED("useResourceSimulationType")] 
		public CBool UseResourceSimulationType
		{
			get => GetProperty(ref _useResourceSimulationType);
			set => SetProperty(ref _useResourceSimulationType, value);
		}

		[Ordinal(27)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get => GetProperty(ref _startInactive);
			set => SetProperty(ref _startInactive, value);
		}

		[Ordinal(28)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get => GetProperty(ref _filterDataSource);
			set => SetProperty(ref _filterDataSource, value);
		}

		[Ordinal(29)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		public entPhysicalMeshComponent()
		{
			_simulationType = new() { Value = Enums.physicsSimulationType.Kinematic };
		}
	}
}
