using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StarController : inkWidgetLogicController
	{
		private inkWidgetReference _bountyBadgeWidget;

		[Ordinal(1)] 
		[RED("bountyBadgeWidget")] 
		public inkWidgetReference BountyBadgeWidget
		{
			get
			{
				if (_bountyBadgeWidget == null)
				{
					_bountyBadgeWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bountyBadgeWidget", cr2w, this);
				}
				return _bountyBadgeWidget;
			}
			set
			{
				if (_bountyBadgeWidget == value)
				{
					return;
				}
				_bountyBadgeWidget = value;
				PropertySet(this);
			}
		}

		public StarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
