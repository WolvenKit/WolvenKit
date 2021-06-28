using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseCorrection : CVariable
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

		public animPoseCorrection(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
