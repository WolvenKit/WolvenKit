using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentDangleInfo : RedBaseClass
	{
		private CFloat _dangleSegmentLenght;
		private CFloat _dangleVelocityDamping;
		private CFloat _dangleBendStiffness;
		private CFloat _dangleSegmentStiffness;
		private CFloat _dangleCollisionSphereRadius;

		[Ordinal(0)] 
		[RED("DangleSegmentLenght")] 
		public CFloat DangleSegmentLenght
		{
			get => GetProperty(ref _dangleSegmentLenght);
			set => SetProperty(ref _dangleSegmentLenght, value);
		}

		[Ordinal(1)] 
		[RED("DangleVelocityDamping")] 
		public CFloat DangleVelocityDamping
		{
			get => GetProperty(ref _dangleVelocityDamping);
			set => SetProperty(ref _dangleVelocityDamping, value);
		}

		[Ordinal(2)] 
		[RED("DangleBendStiffness")] 
		public CFloat DangleBendStiffness
		{
			get => GetProperty(ref _dangleBendStiffness);
			set => SetProperty(ref _dangleBendStiffness, value);
		}

		[Ordinal(3)] 
		[RED("DangleSegmentStiffness")] 
		public CFloat DangleSegmentStiffness
		{
			get => GetProperty(ref _dangleSegmentStiffness);
			set => SetProperty(ref _dangleSegmentStiffness, value);
		}

		[Ordinal(4)] 
		[RED("DangleCollisionSphereRadius")] 
		public CFloat DangleCollisionSphereRadius
		{
			get => GetProperty(ref _dangleCollisionSphereRadius);
			set => SetProperty(ref _dangleCollisionSphereRadius, value);
		}

		public entdismembermentDangleInfo()
		{
			_dangleSegmentLenght = 0.100000F;
			_dangleVelocityDamping = 0.400000F;
			_dangleBendStiffness = 0.600000F;
			_dangleCollisionSphereRadius = 0.250000F;
		}
	}
}
