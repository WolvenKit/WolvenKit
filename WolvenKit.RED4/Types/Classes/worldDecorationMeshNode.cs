using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDecorationMeshNode : worldMeshNode
	{
		[Ordinal(16)] 
		[RED("startAsleep")] 
		public CBool StartAsleep
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get => GetPropertyValue<CEnum<physicsFilterDataSource>>();
			set => SetPropertyValue<CEnum<physicsFilterDataSource>>(value);
		}

		[Ordinal(18)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		public worldDecorationMeshNode()
		{
			FilterDataSource = Enums.physicsFilterDataSource.Collider;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
