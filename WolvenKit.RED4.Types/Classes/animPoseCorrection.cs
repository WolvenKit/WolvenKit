using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animPoseCorrection : RedBaseClass
	{
		private CFloat _rbfCoefficient;
		private CFloat _rbfPowValue;
		private CStatic<animCompareBone> _compareBones;
		private CStatic<animBoneCorrection> _boneCorrections;

		[Ordinal(0)] 
		[RED("rbfCoefficient")] 
		public CFloat RbfCoefficient
		{
			get => GetProperty(ref _rbfCoefficient);
			set => SetProperty(ref _rbfCoefficient, value);
		}

		[Ordinal(1)] 
		[RED("rbfPowValue")] 
		public CFloat RbfPowValue
		{
			get => GetProperty(ref _rbfPowValue);
			set => SetProperty(ref _rbfPowValue, value);
		}

		[Ordinal(2)] 
		[RED("compareBones", 4)] 
		public CStatic<animCompareBone> CompareBones
		{
			get => GetProperty(ref _compareBones);
			set => SetProperty(ref _compareBones, value);
		}

		[Ordinal(3)] 
		[RED("boneCorrections", 4)] 
		public CStatic<animBoneCorrection> BoneCorrections
		{
			get => GetProperty(ref _boneCorrections);
			set => SetProperty(ref _boneCorrections, value);
		}

		public animPoseCorrection()
		{
			_rbfCoefficient = 3.500000F;
			_rbfPowValue = 20.000000F;
		}
	}
}
