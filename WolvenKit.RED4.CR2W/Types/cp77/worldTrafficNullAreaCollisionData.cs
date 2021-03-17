using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaCollisionData : ISerializable
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

		public worldTrafficNullAreaCollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
