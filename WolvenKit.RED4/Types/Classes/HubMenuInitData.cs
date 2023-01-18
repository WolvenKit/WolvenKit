using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HubMenuInitData : IScriptable
	{
		[Ordinal(0)] 
		[RED("menuName")] 
		public CName MenuName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("submenuName")] 
		public CName SubmenuName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		public HubMenuInitData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
