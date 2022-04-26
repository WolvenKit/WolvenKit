using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animRigPartBone : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bone")] 
		public CName Bone
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

		public animRigPartBone()
		{
			Weight = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
