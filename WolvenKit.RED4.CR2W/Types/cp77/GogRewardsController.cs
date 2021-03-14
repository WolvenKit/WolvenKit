using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GogRewardsController : inkWidgetLogicController
	{
		private inkWidgetReference _containerWidget;

		[Ordinal(1)] 
		[RED("containerWidget")] 
		public inkWidgetReference ContainerWidget
		{
			get
			{
				if (_containerWidget == null)
				{
					_containerWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "containerWidget", cr2w, this);
				}
				return _containerWidget;
			}
			set
			{
				if (_containerWidget == value)
				{
					return;
				}
				_containerWidget = value;
				PropertySet(this);
			}
		}

		public GogRewardsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
