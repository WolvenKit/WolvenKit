using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexListVirtualNestedDataView : VirtualNestedListDataView
	{
		private CEnum<CodexCategoryType> _currentFilter;

		[Ordinal(3)] 
		[RED("currentFilter")] 
		public CEnum<CodexCategoryType> CurrentFilter
		{
			get
			{
				if (_currentFilter == null)
				{
					_currentFilter = (CEnum<CodexCategoryType>) CR2WTypeManager.Create("CodexCategoryType", "currentFilter", cr2w, this);
				}
				return _currentFilter;
			}
			set
			{
				if (_currentFilter == value)
				{
					return;
				}
				_currentFilter = value;
				PropertySet(this);
			}
		}

		public CodexListVirtualNestedDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
