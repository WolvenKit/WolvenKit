using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMinimizeCallRequest : gameScriptableSystemRequest
	{
		private CBool _minimized;

		[Ordinal(0)] 
		[RED("minimized")] 
		public CBool Minimized
		{
			get => GetProperty(ref _minimized);
			set => SetProperty(ref _minimized, value);
		}

		public questMinimizeCallRequest()
		{
			_minimized = true;
		}
	}
}
