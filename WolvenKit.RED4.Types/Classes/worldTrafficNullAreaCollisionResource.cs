using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficNullAreaCollisionResource : CResource
	{
		private CHandle<worldTrafficNullAreaCollisionData> _nullAreasCollisionData;
		private CHandle<worldTrafficNullAreaDynamicBlockadeData> _nullAreaBlockadeData;

		[Ordinal(1)] 
		[RED("nullAreasCollisionData")] 
		public CHandle<worldTrafficNullAreaCollisionData> NullAreasCollisionData
		{
			get => GetProperty(ref _nullAreasCollisionData);
			set => SetProperty(ref _nullAreasCollisionData, value);
		}

		[Ordinal(2)] 
		[RED("nullAreaBlockadeData")] 
		public CHandle<worldTrafficNullAreaDynamicBlockadeData> NullAreaBlockadeData
		{
			get => GetProperty(ref _nullAreaBlockadeData);
			set => SetProperty(ref _nullAreaBlockadeData, value);
		}
	}
}
