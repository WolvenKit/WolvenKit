using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animCompareBone : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("boneRotationLs")] 
		public Quaternion BoneRotationLs
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public animCompareBone()
		{
			BoneRotationLs = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
