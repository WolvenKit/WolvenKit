using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksSkillsLevelDisplayController : inkWidgetLogicController
	{
		private inkWidgetReference _tint;

		[Ordinal(1)] 
		[RED("tint")] 
		public inkWidgetReference Tint
		{
			get
			{
				if (_tint == null)
				{
					_tint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "tint", cr2w, this);
				}
				return _tint;
			}
			set
			{
				if (_tint == value)
				{
					return;
				}
				_tint = value;
				PropertySet(this);
			}
		}

		public PerksSkillsLevelDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
