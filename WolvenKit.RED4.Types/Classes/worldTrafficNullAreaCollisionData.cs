using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficNullAreaCollisionData : ISerializable
	{
		private worldCrowdNullAreaCollisionHeader _header;
		private CArray<worldCrowdNullAreaCollisionData> _nullAreaCollisions;

		[Ordinal(0)] 
		[RED("header")] 
		public worldCrowdNullAreaCollisionHeader Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(1)] 
		[RED("nullAreaCollisions")] 
		public CArray<worldCrowdNullAreaCollisionData> NullAreaCollisions
		{
			get => GetProperty(ref _nullAreaCollisions);
			set => SetProperty(ref _nullAreaCollisions, value);
		}
	}
}
