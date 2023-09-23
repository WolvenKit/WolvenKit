using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhotoModeDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("IsActive")] 
		public gamebbScriptID_Bool IsActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("PlayerHealthState")] 
		public gamebbScriptID_Uint32 PlayerHealthState
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		public PhotoModeDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
