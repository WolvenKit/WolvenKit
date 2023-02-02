using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_SceneScreenDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("AnimName")] 
		public gamebbScriptID_CName AnimName
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		public UI_SceneScreenDef()
		{
			AnimName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
