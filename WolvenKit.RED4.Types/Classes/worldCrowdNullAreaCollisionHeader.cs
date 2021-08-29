using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCrowdNullAreaCollisionHeader : RedBaseClass
	{
		private Vector3 _direction;
		private CFloat _radius;
		private CFloat _speed;
		private CUInt8 _flags;
		private CUInt64 _userData;

		[Ordinal(0)] 
		[RED("direction")] 
		public Vector3 Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(2)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(3)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		[Ordinal(4)] 
		[RED("userData")] 
		public CUInt64 UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}
	}
}
