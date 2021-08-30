using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDecorationMeshNode : worldMeshNode
	{
		private CBool _startAsleep;
		private CEnum<physicsFilterDataSource> _filterDataSource;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(15)] 
		[RED("startAsleep")] 
		public CBool StartAsleep
		{
			get => GetProperty(ref _startAsleep);
			set => SetProperty(ref _startAsleep, value);
		}

		[Ordinal(16)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get => GetProperty(ref _filterDataSource);
			set => SetProperty(ref _filterDataSource, value);
		}

		[Ordinal(17)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		public worldDecorationMeshNode()
		{
			_filterDataSource = new() { Value = Enums.physicsFilterDataSource.Collider };
		}
	}
}
