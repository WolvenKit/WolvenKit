using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_SystemDef : gamebbScriptDefinition
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

		public UI_SystemDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
