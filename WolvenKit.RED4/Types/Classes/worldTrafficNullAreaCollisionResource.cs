using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficNullAreaCollisionResource : CResource
	{
		[Ordinal(1)] 
		[RED("nullAreasCollisionData")] 
		public CHandle<worldTrafficNullAreaCollisionData> NullAreasCollisionData
		{
			get => GetPropertyValue<CHandle<worldTrafficNullAreaCollisionData>>();
			set => SetPropertyValue<CHandle<worldTrafficNullAreaCollisionData>>(value);
		}

		[Ordinal(2)] 
		[RED("nullAreaBlockadeData")] 
		public CHandle<worldTrafficNullAreaDynamicBlockadeData> NullAreaBlockadeData
		{
			get => GetPropertyValue<CHandle<worldTrafficNullAreaDynamicBlockadeData>>();
			set => SetPropertyValue<CHandle<worldTrafficNullAreaDynamicBlockadeData>>(value);
		}

		public worldTrafficNullAreaCollisionResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
