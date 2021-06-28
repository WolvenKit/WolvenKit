using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOptionSelectorButton : inkWidgetLogicController
	{
		private inkWidgetReference _overArrow;

		[Ordinal(1)] 
		[RED("overArrow")] 
		public inkWidgetReference OverArrow
		{
			get => GetProperty(ref _overArrow);
			set => SetProperty(ref _overArrow, value);
		}

		public characterCreationBodyMorphOptionSelectorButton(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
