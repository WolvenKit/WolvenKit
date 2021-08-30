using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetPhysicalState : RedBaseClass
	{
		private Vector4 _position;
		private CFloat _worldYaw;
		private Vector4 _velocity;
		private CBool _isOnGround;
		private Vector4 _groundNormal;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("worldYaw")] 
		public CFloat WorldYaw
		{
			get => GetProperty(ref _worldYaw);
			set => SetProperty(ref _worldYaw, value);
		}

		[Ordinal(2)] 
		[RED("velocity")] 
		public Vector4 Velocity
		{
			get => GetProperty(ref _velocity);
			set => SetProperty(ref _velocity, value);
		}

		[Ordinal(3)] 
		[RED("isOnGround")] 
		public CBool IsOnGround
		{
			get => GetProperty(ref _isOnGround);
			set => SetProperty(ref _isOnGround, value);
		}

		[Ordinal(4)] 
		[RED("groundNormal")] 
		public Vector4 GroundNormal
		{
			get => GetProperty(ref _groundNormal);
			set => SetProperty(ref _groundNormal, value);
		}

		public gameMuppetPhysicalState()
		{
			_isOnGround = true;
		}
	}
}
