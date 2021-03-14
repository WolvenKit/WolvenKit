using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GogErrorNotificationController : inkWidgetLogicController
	{
		private inkWidgetReference _errorMessageWidget;

		[Ordinal(1)] 
		[RED("errorMessageWidget")] 
		public inkWidgetReference ErrorMessageWidget
		{
			get
			{
				if (_errorMessageWidget == null)
				{
					_errorMessageWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "errorMessageWidget", cr2w, this);
				}
				return _errorMessageWidget;
			}
			set
			{
				if (_errorMessageWidget == value)
				{
					return;
				}
				_errorMessageWidget = value;
				PropertySet(this);
			}
		}

		public GogErrorNotificationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
