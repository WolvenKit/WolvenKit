using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CodexFilterButtonClicked : redEvent
	{
		[Ordinal(0)] 
		[RED("category")] 
		public CEnum<CodexCategoryType> Category
		{
			get => GetPropertyValue<CEnum<CodexCategoryType>>();
			set => SetPropertyValue<CEnum<CodexCategoryType>>(value);
		}

		[Ordinal(1)] 
		[RED("toggled")] 
		public CBool Toggled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CodexFilterButtonClicked()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
