using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JukeboxBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Bool _isPlaying;

		[Ordinal(7)] 
		[RED("IsPlaying")] 
		public gamebbScriptID_Bool IsPlaying
		{
			get => GetProperty(ref _isPlaying);
			set => SetProperty(ref _isPlaying, value);
		}
	}
}
