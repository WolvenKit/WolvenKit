using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class buildsWidgetGameController : gameuiWidgetGameController
	{
		private CArray<wCHandle<inkHorizontalPanelWidget>> _horizontalPanelsList;

		[Ordinal(2)] 
		[RED("horizontalPanelsList")] 
		public CArray<wCHandle<inkHorizontalPanelWidget>> HorizontalPanelsList
		{
			get => GetProperty(ref _horizontalPanelsList);
			set => SetProperty(ref _horizontalPanelsList, value);
		}

		public buildsWidgetGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
