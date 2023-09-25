using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_SystemDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("IsInMenu")] 
		public gamebbScriptID_Bool IsInMenu
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("CircularBlurEnabled")] 
		public gamebbScriptID_Bool CircularBlurEnabled
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(2)] 
		[RED("CircularBlurBlendTime")] 
		public gamebbScriptID_Float CircularBlurBlendTime
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(3)] 
		[RED("TrackedMappin")] 
		public gamebbScriptID_Variant TrackedMappin
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_SystemDef()
		{
			IsInMenu = new gamebbScriptID_Bool();
			CircularBlurEnabled = new gamebbScriptID_Bool();
			CircularBlurBlendTime = new gamebbScriptID_Float();
			TrackedMappin = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
