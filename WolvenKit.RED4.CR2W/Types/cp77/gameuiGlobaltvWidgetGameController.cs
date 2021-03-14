using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGlobaltvWidgetGameController : gameuiWidgetGameController
	{
		private inkCompoundWidgetReference _overlayContainer;

		[Ordinal(2)] 
		[RED("overlayContainer")] 
		public inkCompoundWidgetReference OverlayContainer
		{
			get
			{
				if (_overlayContainer == null)
				{
					_overlayContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "overlayContainer", cr2w, this);
				}
				return _overlayContainer;
			}
			set
			{
				if (_overlayContainer == value)
				{
					return;
				}
				_overlayContainer = value;
				PropertySet(this);
			}
		}

		public gameuiGlobaltvWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
