using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animRigPart : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("singleBones")] 
		public CArray<animRigPartBone> SingleBones
		{
			get => GetPropertyValue<CArray<animRigPartBone>>();
			set => SetPropertyValue<CArray<animRigPartBone>>(value);
		}

		[Ordinal(2)] 
		[RED("treeBones")] 
		public CArray<animRigPartBoneTree> TreeBones
		{
			get => GetPropertyValue<CArray<animRigPartBoneTree>>();
			set => SetPropertyValue<CArray<animRigPartBoneTree>>(value);
		}

		[Ordinal(3)] 
		[RED("bonesWithRotationInModelSpace")] 
		public CArray<CName> BonesWithRotationInModelSpace
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(4)] 
		[RED("mask")] 
		public CArray<animTransformMask> Mask
		{
			get => GetPropertyValue<CArray<animTransformMask>>();
			set => SetPropertyValue<CArray<animTransformMask>>(value);
		}

		[Ordinal(5)] 
		[RED("maskRotMS")] 
		public CArray<CInt32> MaskRotMS
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		public animRigPart()
		{
			SingleBones = new();
			TreeBones = new();
			BonesWithRotationInModelSpace = new();
			Mask = new();
			MaskRotMS = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
