using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animRigIk2Setup : animIRigIkSetup
	{
		[Ordinal(1)] 
		[RED("firstBone")] 
		public CName FirstBone
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("secondBone")] 
		public CName SecondBone
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("endBone")] 
		public CName EndBone
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("hingeAxis")] 
		public CEnum<animAxis> HingeAxis
		{
			get => GetPropertyValue<CEnum<animAxis>>();
			set => SetPropertyValue<CEnum<animAxis>>(value);
		}

		[Ordinal(5)] 
		[RED("firstBoneIdx")] 
		public CInt16 FirstBoneIdx
		{
			get => GetPropertyValue<CInt16>();
			set => SetPropertyValue<CInt16>(value);
		}

		[Ordinal(6)] 
		[RED("secondBoneIdx")] 
		public CInt16 SecondBoneIdx
		{
			get => GetPropertyValue<CInt16>();
			set => SetPropertyValue<CInt16>(value);
		}

		[Ordinal(7)] 
		[RED("endBoneIdx")] 
		public CInt16 EndBoneIdx
		{
			get => GetPropertyValue<CInt16>();
			set => SetPropertyValue<CInt16>(value);
		}

		public animRigIk2Setup()
		{
			FirstBoneIdx = -1;
			SecondBoneIdx = -1;
			EndBoneIdx = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
