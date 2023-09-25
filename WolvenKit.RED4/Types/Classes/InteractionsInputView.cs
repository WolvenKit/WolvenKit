using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractionsInputView : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("TopArrowRef")] 
		public inkWidgetReference TopArrowRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("BotArrowRef")] 
		public inkWidgetReference BotArrowRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("InputImage")] 
		public inkImageWidgetReference InputImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("ShowArrows")] 
		public CBool ShowArrows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("HasAbove")] 
		public CBool HasAbove
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("HasBelow")] 
		public CBool HasBelow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("CurrentNum")] 
		public CInt32 CurrentNum
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("AllItemsNum")] 
		public CInt32 AllItemsNum
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("DefaultInputPartName")] 
		public CName DefaultInputPartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public InteractionsInputView()
		{
			TopArrowRef = new inkWidgetReference();
			BotArrowRef = new inkWidgetReference();
			InputImage = new inkImageWidgetReference();
			ShowArrows = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
