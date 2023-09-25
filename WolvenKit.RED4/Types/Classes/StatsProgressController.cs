using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatsProgressController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("labelRef")] 
		public inkTextWidgetReference LabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("currentXpRef")] 
		public inkTextWidgetReference CurrentXpRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("maxXpRef")] 
		public inkTextWidgetReference MaxXpRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("currentLevelRef")] 
		public inkTextWidgetReference CurrentLevelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("currentPersentageRef")] 
		public inkTextWidgetReference CurrentPersentageRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("XpWrapper")] 
		public inkWidgetReference XpWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("maxXpWrapper")] 
		public inkWidgetReference MaxXpWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("progressBarFill")] 
		public inkWidgetReference ProgressBarFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("progressBar")] 
		public inkWidgetReference ProgressBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("progressMarkerBar")] 
		public inkWidgetReference ProgressMarkerBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("barLenght")] 
		public CFloat BarLenght
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public StatsProgressController()
		{
			LabelRef = new inkTextWidgetReference();
			CurrentXpRef = new inkTextWidgetReference();
			MaxXpRef = new inkTextWidgetReference();
			CurrentLevelRef = new inkTextWidgetReference();
			CurrentPersentageRef = new inkTextWidgetReference();
			XpWrapper = new inkWidgetReference();
			MaxXpWrapper = new inkWidgetReference();
			ProgressBarFill = new inkWidgetReference();
			ProgressBar = new inkWidgetReference();
			ProgressMarkerBar = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
