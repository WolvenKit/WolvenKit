using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestListHeaderController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("arrow")] 
		public inkWidgetReference Arrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("questType")] 
		public CInt32 QuestType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuestListHeaderController()
		{
			Title = new();
			Arrow = new();
			Root = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
