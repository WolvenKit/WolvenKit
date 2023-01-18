using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPanzerScoreRecord : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("nameWidget")] 
		public inkTextWidgetReference NameWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("scoreWidget")] 
		public inkTextWidgetReference ScoreWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public gameuiPanzerScoreRecord()
		{
			NameWidget = new();
			ScoreWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
