using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseToggleView : inkWidgetLogicController
	{
		private wCHandle<inkToggleController> _toggleController;
		private CEnum<inkEToggleState> _oldState;

		[Ordinal(1)] 
		[RED("ToggleController")] 
		public wCHandle<inkToggleController> ToggleController
		{
			get => GetProperty(ref _toggleController);
			set => SetProperty(ref _toggleController, value);
		}

		[Ordinal(2)] 
		[RED("OldState")] 
		public CEnum<inkEToggleState> OldState
		{
			get => GetProperty(ref _oldState);
			set => SetProperty(ref _oldState, value);
		}

		public BaseToggleView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
