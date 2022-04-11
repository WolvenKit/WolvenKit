using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animRigPartBoneTree : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rootBone")] 
		public CName RootBone
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("subtreesToChange")] 
		public CArray<animRigPartBoneTree> SubtreesToChange
		{
			get => GetPropertyValue<CArray<animRigPartBoneTree>>();
			set => SetPropertyValue<CArray<animRigPartBoneTree>>(value);
		}

		public animRigPartBoneTree()
		{
			Weight = 1.000000F;
			SubtreesToChange = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
