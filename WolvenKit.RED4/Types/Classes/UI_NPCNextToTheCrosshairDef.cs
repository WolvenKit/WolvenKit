using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_NPCNextToTheCrosshairDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("NameplateData")] 
		public gamebbScriptID_Variant NameplateData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("BuffsList")] 
		public gamebbScriptID_Variant BuffsList
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("DebuffsList")] 
		public gamebbScriptID_Variant DebuffsList
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_NPCNextToTheCrosshairDef()
		{
			NameplateData = new();
			BuffsList = new();
			DebuffsList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
