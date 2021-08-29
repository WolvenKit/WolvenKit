using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsColliderBox : physicsICollider
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
	}
}
