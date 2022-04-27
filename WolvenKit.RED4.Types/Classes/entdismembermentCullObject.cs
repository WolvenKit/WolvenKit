using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentCullObject : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Plane")] 
		public Plane Plane
		{
			get => GetPropertyValue<Plane>();
			set => SetPropertyValue<Plane>(value);
		}

		[Ordinal(1)] 
		[RED("Plane1")] 
		public Plane Plane1
		{
			get => GetPropertyValue<Plane>();
			set => SetPropertyValue<Plane>(value);
		}

		[Ordinal(2)] 
		[RED("CapsulePointA")] 
		public Vector3 CapsulePointA
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("CapsulePointB")] 
		public Vector3 CapsulePointB
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("CapsuleRadius")] 
		public CFloat CapsuleRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("NearestAnimBoneName")] 
		public CName NearestAnimBoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("NearestAnimIndex")] 
		public CInt16 NearestAnimIndex
		{
			get => GetPropertyValue<CInt16>();
			set => SetPropertyValue<CInt16>(value);
		}

		[Ordinal(7)] 
		[RED("RagdollBodyIndex")] 
		public CUInt16 RagdollBodyIndex
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public entdismembermentCullObject()
		{
			Plane = new() { NormalDistance = new() { Z = 1.000000F, W = -0.000000F } };
			Plane1 = new() { NormalDistance = new() { Z = 1.000000F, W = -0.000000F } };
			CapsulePointA = new();
			CapsulePointB = new();
			CapsuleRadius = 0.100000F;
			NearestAnimIndex = -1;
			RagdollBodyIndex = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
