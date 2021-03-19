using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveComponentReplicatedState : netIComponentState
	{
		private Quaternion _rotation;
		private Vector3 _position;
		private Vector3 _linearVelocity;
		private CInt16 _teleportCount;
		private CBool _touchesGround;
		private CBool _touchesWalls;
		private CBool _physicalMove;
		private netTime _inputTimestamp;

		[Ordinal(2)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(3)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(4)] 
		[RED("linearVelocity")] 
		public Vector3 LinearVelocity
		{
			get => GetProperty(ref _linearVelocity);
			set => SetProperty(ref _linearVelocity, value);
		}

		[Ordinal(5)] 
		[RED("teleportCount")] 
		public CInt16 TeleportCount
		{
			get => GetProperty(ref _teleportCount);
			set => SetProperty(ref _teleportCount, value);
		}

		[Ordinal(6)] 
		[RED("touchesGround")] 
		public CBool TouchesGround
		{
			get => GetProperty(ref _touchesGround);
			set => SetProperty(ref _touchesGround, value);
		}

		[Ordinal(7)] 
		[RED("touchesWalls")] 
		public CBool TouchesWalls
		{
			get => GetProperty(ref _touchesWalls);
			set => SetProperty(ref _touchesWalls, value);
		}

		[Ordinal(8)] 
		[RED("physicalMove")] 
		public CBool PhysicalMove
		{
			get => GetProperty(ref _physicalMove);
			set => SetProperty(ref _physicalMove, value);
		}

		[Ordinal(9)] 
		[RED("inputTimestamp")] 
		public netTime InputTimestamp
		{
			get => GetProperty(ref _inputTimestamp);
			set => SetProperty(ref _inputTimestamp, value);
		}

		public moveComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
