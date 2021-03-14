using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModEntryController : inkWidgetLogicController
	{
		private inkTextWidgetReference _modName;

		[Ordinal(1)] 
		[RED("modName")] 
		public inkTextWidgetReference ModName
		{
			get
			{
				if (_modName == null)
				{
					_modName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "modName", cr2w, this);
				}
				return _modName;
			}
			set
			{
				if (_modName == value)
				{
					return;
				}
				_modName = value;
				PropertySet(this);
			}
		}

		public ItemTooltipModEntryController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
