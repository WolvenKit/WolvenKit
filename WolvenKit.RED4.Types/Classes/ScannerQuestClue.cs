using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerQuestClue : inkWidgetLogicController
	{
		private inkTextWidgetReference _categoryTextRef;
		private inkTextWidgetReference _descriptionTextRef;
		private inkImageWidgetReference _iconRef;

		[Ordinal(1)] 
		[RED("CategoryTextRef")] 
		public inkTextWidgetReference CategoryTextRef
		{
			get => GetProperty(ref _categoryTextRef);
			set => SetProperty(ref _categoryTextRef, value);
		}

		[Ordinal(2)] 
		[RED("DescriptionTextRef")] 
		public inkTextWidgetReference DescriptionTextRef
		{
			get => GetProperty(ref _descriptionTextRef);
			set => SetProperty(ref _descriptionTextRef, value);
		}

		[Ordinal(3)] 
		[RED("IconRef")] 
		public inkImageWidgetReference IconRef
		{
			get => GetProperty(ref _iconRef);
			set => SetProperty(ref _iconRef, value);
		}
	}
}
