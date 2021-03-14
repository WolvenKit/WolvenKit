using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questQuickItemsManager_NodeType : questIUIManagerNodeType
	{
		private CEnum<questQuickItemsSet> _set;

		[Ordinal(0)] 
		[RED("set")] 
		public CEnum<questQuickItemsSet> Set
		{
			get
			{
				if (_set == null)
				{
					_set = (CEnum<questQuickItemsSet>) CR2WTypeManager.Create("questQuickItemsSet", "set", cr2w, this);
				}
				return _set;
			}
			set
			{
				if (_set == value)
				{
					return;
				}
				_set = value;
				PropertySet(this);
			}
		}

		public questQuickItemsManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
