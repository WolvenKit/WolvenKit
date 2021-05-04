using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapQuestAreaMappinController : gameuiBaseMinimapMappinController
	{
		private inkShapeWidgetReference _areaShapeWidget;

		[Ordinal(14)] 
		[RED("areaShapeWidget")] 
		public inkShapeWidgetReference AreaShapeWidget
		{
			get => GetProperty(ref _areaShapeWidget);
			set => SetProperty(ref _areaShapeWidget, value);
		}

		public gameuiMinimapQuestAreaMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
