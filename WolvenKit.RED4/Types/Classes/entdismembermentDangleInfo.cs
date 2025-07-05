using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentDangleInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("DangleSegmentLenght")] 
		public CFloat DangleSegmentLenght
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("DangleVelocityDamping")] 
		public CFloat DangleVelocityDamping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("DangleBendStiffness")] 
		public CFloat DangleBendStiffness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("DangleSegmentStiffness")] 
		public CFloat DangleSegmentStiffness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("DangleCollisionSphereRadius")] 
		public CFloat DangleCollisionSphereRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entdismembermentDangleInfo()
		{
			DangleSegmentLenght = 0.100000F;
			DangleVelocityDamping = 0.400000F;
			DangleBendStiffness = 0.600000F;
			DangleCollisionSphereRadius = 0.250000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
