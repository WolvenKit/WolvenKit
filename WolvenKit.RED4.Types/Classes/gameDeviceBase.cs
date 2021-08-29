using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeviceBase : gameObject
	{
		private CBool _isLogicReady;

		[Ordinal(40)] 
		[RED("isLogicReady")] 
		public CBool IsLogicReady
		{
			get => GetProperty(ref _isLogicReady);
			set => SetProperty(ref _isLogicReady, value);
		}
	}
}
