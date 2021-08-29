using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickHackSetDescriptionVisibilityRequest : gameScriptableSystemRequest
	{
		private CBool _visible;

		[Ordinal(0)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetProperty(ref _visible);
			set => SetProperty(ref _visible, value);
		}
	}
}
