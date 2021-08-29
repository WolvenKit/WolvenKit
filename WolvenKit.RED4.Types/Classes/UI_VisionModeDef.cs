using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_VisionModeDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isEnabled;

		[Ordinal(0)] 
		[RED("isEnabled")] 
		public gamebbScriptID_Bool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}
	}
}
