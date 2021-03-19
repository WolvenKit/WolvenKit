using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticLaneCollisions : CVariable
	{
		private worldTrafficLaneUID _lane;
		private CArray<worldTrafficStaticCollisionSphere> _collisions;
		private CFloat _deadEndStart;

		[Ordinal(0)] 
		[RED("lane")] 
		public worldTrafficLaneUID Lane
		{
			get => GetProperty(ref _lane);
			set => SetProperty(ref _lane, value);
		}

		[Ordinal(1)] 
		[RED("collisions")] 
		public CArray<worldTrafficStaticCollisionSphere> Collisions
		{
			get => GetProperty(ref _collisions);
			set => SetProperty(ref _collisions, value);
		}

		[Ordinal(2)] 
		[RED("deadEndStart")] 
		public CFloat DeadEndStart
		{
			get => GetProperty(ref _deadEndStart);
			set => SetProperty(ref _deadEndStart, value);
		}

		public worldStaticLaneCollisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
