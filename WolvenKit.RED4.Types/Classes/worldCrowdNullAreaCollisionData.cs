using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCrowdNullAreaCollisionData : RedBaseClass
	{
		private CUInt64 _areaID;
		private CArray<worldTrafficStaticCollisionSphere> _collisions;

		[Ordinal(0)] 
		[RED("areaID")] 
		public CUInt64 AreaID
		{
			get => GetProperty(ref _areaID);
			set => SetProperty(ref _areaID, value);
		}

		[Ordinal(1)] 
		[RED("collisions")] 
		public CArray<worldTrafficStaticCollisionSphere> Collisions
		{
			get => GetProperty(ref _collisions);
			set => SetProperty(ref _collisions, value);
		}
	}
}
