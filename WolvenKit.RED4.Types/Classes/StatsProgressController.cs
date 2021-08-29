using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatsProgressController : inkWidgetLogicController
	{
		private inkTextWidgetReference _labelRef;
		private inkTextWidgetReference _currentXpRef;
		private inkTextWidgetReference _maxXpRef;
		private inkTextWidgetReference _currentLevelRef;
		private inkTextWidgetReference _currentPersentageRef;
		private inkWidgetReference _xpWrapper;
		private inkWidgetReference _maxXpWrapper;
		private inkWidgetReference _progressBarFill;
		private inkWidgetReference _progressBar;
		private inkWidgetReference _progressMarkerBar;
		private CFloat _barLenght;

		[Ordinal(1)] 
		[RED("labelRef")] 
		public inkTextWidgetReference LabelRef
		{
			get => GetProperty(ref _labelRef);
			set => SetProperty(ref _labelRef, value);
		}

		[Ordinal(2)] 
		[RED("currentXpRef")] 
		public inkTextWidgetReference CurrentXpRef
		{
			get => GetProperty(ref _currentXpRef);
			set => SetProperty(ref _currentXpRef, value);
		}

		[Ordinal(3)] 
		[RED("maxXpRef")] 
		public inkTextWidgetReference MaxXpRef
		{
			get => GetProperty(ref _maxXpRef);
			set => SetProperty(ref _maxXpRef, value);
		}

		[Ordinal(4)] 
		[RED("currentLevelRef")] 
		public inkTextWidgetReference CurrentLevelRef
		{
			get => GetProperty(ref _currentLevelRef);
			set => SetProperty(ref _currentLevelRef, value);
		}

		[Ordinal(5)] 
		[RED("currentPersentageRef")] 
		public inkTextWidgetReference CurrentPersentageRef
		{
			get => GetProperty(ref _currentPersentageRef);
			set => SetProperty(ref _currentPersentageRef, value);
		}

		[Ordinal(6)] 
		[RED("XpWrapper")] 
		public inkWidgetReference XpWrapper
		{
			get => GetProperty(ref _xpWrapper);
			set => SetProperty(ref _xpWrapper, value);
		}

		[Ordinal(7)] 
		[RED("maxXpWrapper")] 
		public inkWidgetReference MaxXpWrapper
		{
			get => GetProperty(ref _maxXpWrapper);
			set => SetProperty(ref _maxXpWrapper, value);
		}

		[Ordinal(8)] 
		[RED("progressBarFill")] 
		public inkWidgetReference ProgressBarFill
		{
			get => GetProperty(ref _progressBarFill);
			set => SetProperty(ref _progressBarFill, value);
		}

		[Ordinal(9)] 
		[RED("progressBar")] 
		public inkWidgetReference ProgressBar
		{
			get => GetProperty(ref _progressBar);
			set => SetProperty(ref _progressBar, value);
		}

		[Ordinal(10)] 
		[RED("progressMarkerBar")] 
		public inkWidgetReference ProgressMarkerBar
		{
			get => GetProperty(ref _progressMarkerBar);
			set => SetProperty(ref _progressMarkerBar, value);
		}

		[Ordinal(11)] 
		[RED("barLenght")] 
		public CFloat BarLenght
		{
			get => GetProperty(ref _barLenght);
			set => SetProperty(ref _barLenght, value);
		}
	}
}
