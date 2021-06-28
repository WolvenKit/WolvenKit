using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDiscreteNavigationController : inkWidgetLogicController
	{
		private CBool _shouldUpdateScrollController;
		private CBool _isNavigalbe;
		private CBool _supportsHoldInput;

		[Ordinal(1)] 
		[RED("shouldUpdateScrollController")] 
		public CBool ShouldUpdateScrollController
		{
			get => GetProperty(ref _shouldUpdateScrollController);
			set => SetProperty(ref _shouldUpdateScrollController, value);
		}

		[Ordinal(2)] 
		[RED("isNavigalbe")] 
		public CBool IsNavigalbe
		{
			get => GetProperty(ref _isNavigalbe);
			set => SetProperty(ref _isNavigalbe, value);
		}

		[Ordinal(3)] 
		[RED("supportsHoldInput")] 
		public CBool SupportsHoldInput
		{
			get => GetProperty(ref _supportsHoldInput);
			set => SetProperty(ref _supportsHoldInput, value);
		}

		public inkDiscreteNavigationController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
