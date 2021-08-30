using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsPhysicsJointLimitConePair : physicsPhysicsJointLimitBase
	{
		private CEnum<physicsPhysicsJointMotion> _swingY;
		private CEnum<physicsPhysicsJointMotion> _swingZ;
		private CFloat _yAngle;
		private CFloat _zAngle;

		[Ordinal(5)] 
		[RED("swingY")] 
		public CEnum<physicsPhysicsJointMotion> SwingY
		{
			get => GetProperty(ref _swingY);
			set => SetProperty(ref _swingY, value);
		}

		[Ordinal(6)] 
		[RED("swingZ")] 
		public CEnum<physicsPhysicsJointMotion> SwingZ
		{
			get => GetProperty(ref _swingZ);
			set => SetProperty(ref _swingZ, value);
		}

		[Ordinal(7)] 
		[RED("yAngle")] 
		public CFloat YAngle
		{
			get => GetProperty(ref _yAngle);
			set => SetProperty(ref _yAngle, value);
		}

		[Ordinal(8)] 
		[RED("zAngle")] 
		public CFloat ZAngle
		{
			get => GetProperty(ref _zAngle);
			set => SetProperty(ref _zAngle, value);
		}

		public physicsPhysicsJointLimitConePair()
		{
			_yAngle = 0.000000F;
			_zAngle = 0.000000F;
		}
	}
}
