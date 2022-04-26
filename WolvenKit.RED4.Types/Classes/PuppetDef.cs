using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PuppetDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("IsCrowd")] 
		public gamebbScriptID_Bool IsCrowd
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("HideNameplate")] 
		public gamebbScriptID_Bool HideNameplate
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(2)] 
		[RED("ForceFriendlyCarry")] 
		public gamebbScriptID_Bool ForceFriendlyCarry
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("ForcedCarryStyle")] 
		public gamebbScriptID_Int32 ForcedCarryStyle
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(4)] 
		[RED("HasCPOMissionData")] 
		public gamebbScriptID_Bool HasCPOMissionData
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public PuppetDef()
		{
			IsCrowd = new();
			HideNameplate = new();
			ForceFriendlyCarry = new();
			ForcedCarryStyle = new();
			HasCPOMissionData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
