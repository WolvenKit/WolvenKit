using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HubExperienceBarController : inkWidgetLogicController
	{
		private inkWidgetReference _foregroundContainer;

		[Ordinal(1)] 
		[RED("foregroundContainer")] 
		public inkWidgetReference ForegroundContainer
		{
			get
			{
				if (_foregroundContainer == null)
				{
					_foregroundContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "foregroundContainer", cr2w, this);
				}
				return _foregroundContainer;
			}
			set
			{
				if (_foregroundContainer == value)
				{
					return;
				}
				_foregroundContainer = value;
				PropertySet(this);
			}
		}

		public HubExperienceBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
