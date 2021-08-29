using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_SystemDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isInMenu;
		private gamebbScriptID_Bool _circularBlurEnabled;
		private gamebbScriptID_Float _circularBlurBlendTime;
		private gamebbScriptID_Variant _trackedMappin;

		[Ordinal(0)] 
		[RED("IsInMenu")] 
		public gamebbScriptID_Bool IsInMenu
		{
			get => GetProperty(ref _isInMenu);
			set => SetProperty(ref _isInMenu, value);
		}

		[Ordinal(1)] 
		[RED("CircularBlurEnabled")] 
		public gamebbScriptID_Bool CircularBlurEnabled
		{
			get => GetProperty(ref _circularBlurEnabled);
			set => SetProperty(ref _circularBlurEnabled, value);
		}

		[Ordinal(2)] 
		[RED("CircularBlurBlendTime")] 
		public gamebbScriptID_Float CircularBlurBlendTime
		{
			get => GetProperty(ref _circularBlurBlendTime);
			set => SetProperty(ref _circularBlurBlendTime, value);
		}

		[Ordinal(3)] 
		[RED("TrackedMappin")] 
		public gamebbScriptID_Variant TrackedMappin
		{
			get => GetProperty(ref _trackedMappin);
			set => SetProperty(ref _trackedMappin, value);
		}
	}
}
