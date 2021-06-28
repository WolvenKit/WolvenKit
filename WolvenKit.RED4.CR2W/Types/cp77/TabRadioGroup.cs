using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TabRadioGroup : inkRadioGroupController
	{
		private inkCompoundWidgetReference _root;
		private CArray<wCHandle<TabButtonController>> _toggles;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;

		[Ordinal(5)] 
		[RED("root")] 
		public inkCompoundWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(6)] 
		[RED("toggles")] 
		public CArray<wCHandle<TabButtonController>> Toggles
		{
			get => GetProperty(ref _toggles);
			set => SetProperty(ref _toggles, value);
		}

		[Ordinal(7)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		public TabRadioGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
