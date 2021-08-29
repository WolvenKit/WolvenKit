using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConfessionalBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Bool _isConfessing;

		[Ordinal(7)] 
		[RED("IsConfessing")] 
		public gamebbScriptID_Bool IsConfessing
		{
			get => GetProperty(ref _isConfessing);
			set => SetProperty(ref _isConfessing, value);
		}
	}
}
