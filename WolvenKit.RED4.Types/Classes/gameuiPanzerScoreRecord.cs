using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPanzerScoreRecord : inkWidgetLogicController
	{
		private inkTextWidgetReference _nameWidget;
		private inkTextWidgetReference _scoreWidget;

		[Ordinal(1)] 
		[RED("nameWidget")] 
		public inkTextWidgetReference NameWidget
		{
			get => GetProperty(ref _nameWidget);
			set => SetProperty(ref _nameWidget, value);
		}

		[Ordinal(2)] 
		[RED("scoreWidget")] 
		public inkTextWidgetReference ScoreWidget
		{
			get => GetProperty(ref _scoreWidget);
			set => SetProperty(ref _scoreWidget, value);
		}
	}
}
