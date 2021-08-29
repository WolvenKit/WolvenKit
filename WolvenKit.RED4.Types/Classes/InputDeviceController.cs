using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InputDeviceController : gameScriptableComponent
	{
		private CBool _isStarted;

		[Ordinal(5)] 
		[RED("isStarted")] 
		public CBool IsStarted
		{
			get => GetProperty(ref _isStarted);
			set => SetProperty(ref _isStarted, value);
		}
	}
}
