using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animCompareBone : RedBaseClass
	{
		private CName _boneName;
		private Quaternion _boneRotationLs;

		[Ordinal(0)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetProperty(ref _boneName);
			set => SetProperty(ref _boneName, value);
		}

		[Ordinal(1)] 
		[RED("boneRotationLs")] 
		public Quaternion BoneRotationLs
		{
			get => GetProperty(ref _boneRotationLs);
			set => SetProperty(ref _boneRotationLs, value);
		}
	}
}
