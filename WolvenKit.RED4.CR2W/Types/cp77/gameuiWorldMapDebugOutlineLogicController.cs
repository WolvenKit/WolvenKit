using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapDebugOutlineLogicController : inkWidgetLogicController
	{
		private inkShapeWidgetReference _outlineWidget;

		[Ordinal(1)] 
		[RED("outlineWidget")] 
		public inkShapeWidgetReference OutlineWidget
		{
			get => GetProperty(ref _outlineWidget);
			set => SetProperty(ref _outlineWidget, value);
		}

		public gameuiWorldMapDebugOutlineLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
