using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerQuestClue : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("CategoryTextRef")] 
		public inkTextWidgetReference CategoryTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("DescriptionTextRef")] 
		public inkTextWidgetReference DescriptionTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("IconRef")] 
		public inkImageWidgetReference IconRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public ScannerQuestClue()
		{
			CategoryTextRef = new inkTextWidgetReference();
			DescriptionTextRef = new inkTextWidgetReference();
			IconRef = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
