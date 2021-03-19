using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCrowdNullAreaCollisionData : CVariable
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

		public worldCrowdNullAreaCollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
