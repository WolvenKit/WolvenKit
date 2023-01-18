using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animBoneCorrection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("additiveCorrection")] 
		public Quaternion AdditiveCorrection
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public animBoneCorrection()
		{
			AdditiveCorrection = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
