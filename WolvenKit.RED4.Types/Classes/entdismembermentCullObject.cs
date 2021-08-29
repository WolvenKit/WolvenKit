using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentCullObject : RedBaseClass
	{
		private Plane _plane;
		private Plane _plane1;
		private Vector3 _capsulePointA;
		private Vector3 _capsulePointB;
		private CFloat _capsuleRadius;
		private CName _nearestAnimBoneName;
		private CInt16 _nearestAnimIndex;
		private CUInt16 _ragdollBodyIndex;

		[Ordinal(0)] 
		[RED("Plane")] 
		public Plane Plane
		{
			get => GetProperty(ref _plane);
			set => SetProperty(ref _plane, value);
		}

		[Ordinal(1)] 
		[RED("Plane1")] 
		public Plane Plane1
		{
			get => GetProperty(ref _plane1);
			set => SetProperty(ref _plane1, value);
		}

		[Ordinal(2)] 
		[RED("CapsulePointA")] 
		public Vector3 CapsulePointA
		{
			get => GetProperty(ref _capsulePointA);
			set => SetProperty(ref _capsulePointA, value);
		}

		[Ordinal(3)] 
		[RED("CapsulePointB")] 
		public Vector3 CapsulePointB
		{
			get => GetProperty(ref _capsulePointB);
			set => SetProperty(ref _capsulePointB, value);
		}

		[Ordinal(4)] 
		[RED("CapsuleRadius")] 
		public CFloat CapsuleRadius
		{
			get => GetProperty(ref _capsuleRadius);
			set => SetProperty(ref _capsuleRadius, value);
		}

		[Ordinal(5)] 
		[RED("NearestAnimBoneName")] 
		public CName NearestAnimBoneName
		{
			get => GetProperty(ref _nearestAnimBoneName);
			set => SetProperty(ref _nearestAnimBoneName, value);
		}

		[Ordinal(6)] 
		[RED("NearestAnimIndex")] 
		public CInt16 NearestAnimIndex
		{
			get => GetProperty(ref _nearestAnimIndex);
			set => SetProperty(ref _nearestAnimIndex, value);
		}

		[Ordinal(7)] 
		[RED("RagdollBodyIndex")] 
		public CUInt16 RagdollBodyIndex
		{
			get => GetProperty(ref _ragdollBodyIndex);
			set => SetProperty(ref _ragdollBodyIndex, value);
		}
	}
}
