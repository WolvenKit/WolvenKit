using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DlcDescriptionController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("titleRef")] 
		public inkTextWidgetReference TitleRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("descriptionRef")] 
		public inkTextWidgetReference DescriptionRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("guideRef")] 
		public inkTextWidgetReference GuideRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("imageRef")] 
		public inkImageWidgetReference ImageRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public DlcDescriptionController()
		{
			TitleRef = new();
			DescriptionRef = new();
			GuideRef = new();
			ImageRef = new();
		}
	}
}
