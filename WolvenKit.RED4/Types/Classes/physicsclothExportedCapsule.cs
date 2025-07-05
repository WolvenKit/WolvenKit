using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsclothExportedCapsule : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("p0")] 
		public Vector3 P0
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("p1")] 
		public Vector3 P1
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("r0")] 
		public CFloat R0
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("r1")] 
		public CFloat R1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public physicsclothExportedCapsule()
		{
			P0 = new Vector3();
			P1 = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
