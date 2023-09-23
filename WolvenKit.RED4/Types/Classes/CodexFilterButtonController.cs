using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CodexFilterButtonController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("category")] 
		public CEnum<CodexCategoryType> Category
		{
			get => GetPropertyValue<CEnum<CodexCategoryType>>();
			set => SetPropertyValue<CEnum<CodexCategoryType>>(value);
		}

		[Ordinal(4)] 
		[RED("toggled")] 
		public CBool Toggled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CodexFilterButtonController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
