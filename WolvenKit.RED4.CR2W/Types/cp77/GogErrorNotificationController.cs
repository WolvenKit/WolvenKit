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
			get => GetProperty(ref _errorMessageWidget);
			set => SetProperty(ref _errorMessageWidget, value);
		}

		public GogErrorNotificationController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
