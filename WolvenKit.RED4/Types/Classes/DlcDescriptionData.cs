using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DlcDescriptionData : inkUserData
	{
		[Ordinal(0)] 
		[RED("title")] 
		public CName Title
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CName Description
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("guide")] 
		public CName Guide
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("imagePart")] 
		public CName ImagePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("settingVar")] 
		public CHandle<userSettingsVar> SettingVar
		{
			get => GetPropertyValue<CHandle<userSettingsVar>>();
			set => SetPropertyValue<CHandle<userSettingsVar>>(value);
		}

		[Ordinal(5)] 
		[RED("isPreGame")] 
		public CBool IsPreGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DlcDescriptionData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
