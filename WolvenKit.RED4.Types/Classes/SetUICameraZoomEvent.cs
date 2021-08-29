using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetUICameraZoomEvent : redEvent
	{
		private CBool _hasUICameraZoom;

		[Ordinal(0)] 
		[RED("hasUICameraZoom")] 
		public CBool HasUICameraZoom
		{
			get => GetProperty(ref _hasUICameraZoom);
			set => SetProperty(ref _hasUICameraZoom, value);
		}
	}
}
