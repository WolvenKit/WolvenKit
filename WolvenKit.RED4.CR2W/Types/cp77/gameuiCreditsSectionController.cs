using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCreditsSectionController : inkWidgetLogicController
	{
		private inkTextWidgetReference _sectionName;

		[Ordinal(1)] 
		[RED("sectionName")] 
		public inkTextWidgetReference SectionName
		{
			get
			{
				if (_sectionName == null)
				{
					_sectionName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "sectionName", cr2w, this);
				}
				return _sectionName;
			}
			set
			{
				if (_sectionName == value)
				{
					return;
				}
				_sectionName = value;
				PropertySet(this);
			}
		}

		public gameuiCreditsSectionController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
