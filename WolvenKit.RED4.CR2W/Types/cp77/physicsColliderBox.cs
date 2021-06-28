using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsColliderBox : physicsICollider
	{
		private Vector3 _halfExtents;
		private CBool _isObstacle;

		[Ordinal(8)] 
		[RED("halfExtents")] 
		public Vector3 HalfExtents
		{
			get => GetProperty(ref _halfExtents);
			set => SetProperty(ref _halfExtents, value);
		}

		[Ordinal(9)] 
		[RED("isObstacle")] 
		public CBool IsObstacle
		{
			get => GetProperty(ref _isObstacle);
			set => SetProperty(ref _isObstacle, value);
		}

		public physicsColliderBox(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
