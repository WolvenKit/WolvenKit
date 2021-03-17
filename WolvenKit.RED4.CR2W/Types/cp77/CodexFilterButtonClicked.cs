using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexFilterButtonClicked : redEvent
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

		public CodexFilterButtonClicked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
