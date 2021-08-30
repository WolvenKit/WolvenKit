using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiInteractionMappinController : gameuiMappinBaseController
	{
		private CBool _isCurrentlyClamped;
		private CBool _isUnderCrosshair;
		private CName _canvasWidgetName;
		private CName _arrowWidgetName;

		[Ordinal(7)] 
		[RED("isCurrentlyClamped")] 
		public CBool IsCurrentlyClamped
		{
			get => GetProperty(ref _isCurrentlyClamped);
			set => SetProperty(ref _isCurrentlyClamped, value);
		}

		[Ordinal(8)] 
		[RED("isUnderCrosshair")] 
		public CBool IsUnderCrosshair
		{
			get => GetProperty(ref _isUnderCrosshair);
			set => SetProperty(ref _isUnderCrosshair, value);
		}

		[Ordinal(9)] 
		[RED("canvasWidgetName")] 
		public CName CanvasWidgetName
		{
			get => GetProperty(ref _canvasWidgetName);
			set => SetProperty(ref _canvasWidgetName, value);
		}

		[Ordinal(10)] 
		[RED("arrowWidgetName")] 
		public CName ArrowWidgetName
		{
			get => GetProperty(ref _arrowWidgetName);
			set => SetProperty(ref _arrowWidgetName, value);
		}

		public gameuiInteractionMappinController()
		{
			_canvasWidgetName = "Canvas";
			_arrowWidgetName = "Arrow";
		}
	}
}
