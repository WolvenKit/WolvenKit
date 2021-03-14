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
			get
			{
				if (_category == null)
				{
					_category = (CEnum<CodexCategoryType>) CR2WTypeManager.Create("CodexCategoryType", "category", cr2w, this);
				}
				return _category;
			}
			set
			{
				if (_category == value)
				{
					return;
				}
				_category = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("toggled")] 
		public CBool Toggled
		{
			get
			{
				if (_toggled == null)
				{
					_toggled = (CBool) CR2WTypeManager.Create("Bool", "toggled", cr2w, this);
				}
				return _toggled;
			}
			set
			{
				if (_toggled == value)
				{
					return;
				}
				_toggled = value;
				PropertySet(this);
			}
		}

		public CodexFilterButtonClicked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
