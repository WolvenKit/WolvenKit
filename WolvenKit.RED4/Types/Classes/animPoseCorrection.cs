using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animPoseCorrection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rbfCoefficient")] 
		public CFloat RbfCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("rbfPowValue")] 
		public CFloat RbfPowValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("compareBones", 4)] 
		public CStatic<animCompareBone> CompareBones
		{
			get => GetPropertyValue<CStatic<animCompareBone>>();
			set => SetPropertyValue<CStatic<animCompareBone>>(value);
		}

		[Ordinal(3)] 
		[RED("boneCorrections", 4)] 
		public CStatic<animBoneCorrection> BoneCorrections
		{
			get => GetPropertyValue<CStatic<animBoneCorrection>>();
			set => SetPropertyValue<CStatic<animBoneCorrection>>(value);
		}

		public animPoseCorrection()
		{
			RbfCoefficient = 3.500000F;
			RbfPowValue = 20.000000F;
			CompareBones = new(0);
			BoneCorrections = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
