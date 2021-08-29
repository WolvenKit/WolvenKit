using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_ActivityLogDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _activityLogHide;

		[Ordinal(0)] 
		[RED("activityLogHide")] 
		public gamebbScriptID_Bool ActivityLogHide
		{
			get => GetProperty(ref _activityLogHide);
			set => SetProperty(ref _activityLogHide, value);
		}
	}
}
