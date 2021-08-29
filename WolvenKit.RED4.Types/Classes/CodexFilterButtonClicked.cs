using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexFilterButtonClicked : redEvent
	{
		private CEnum<CodexCategoryType> _category;
		private CBool _toggled;

		[Ordinal(0)] 
		[RED("category")] 
		public CEnum<CodexCategoryType> Category
		{
			get => GetProperty(ref _category);
			set => SetProperty(ref _category, value);
		}

		[Ordinal(1)] 
		[RED("toggled")] 
		public CBool Toggled
		{
			get => GetProperty(ref _toggled);
			set => SetProperty(ref _toggled, value);
		}
	}
}
