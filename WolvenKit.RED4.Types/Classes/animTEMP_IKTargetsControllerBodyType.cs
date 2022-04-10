using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animTEMP_IKTargetsControllerBodyType : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("genderTag")] 
		public CName GenderTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("bodyTypeTag")] 
		public CName BodyTypeTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("ikChainSettings")] 
		public CArray<animIKChainSettings> IkChainSettings
		{
			get => GetPropertyValue<CArray<animIKChainSettings>>();
			set => SetPropertyValue<CArray<animIKChainSettings>>(value);
		}

		public animTEMP_IKTargetsControllerBodyType()
		{
			IkChainSettings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
