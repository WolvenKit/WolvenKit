using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressBarButton : inkWidgetLogicController
	{
		private inkWidgetReference _craftingFill;
		private inkTextWidgetReference _craftingLabel;
		private wCHandle<inkButtonController> _buttonController;
		private wCHandle<ProgressBarsController> _progressController;
		private CBool _available;
		private CFloat _progress;

		[Ordinal(1)] 
		[RED("craftingFill")] 
		public inkWidgetReference CraftingFill
		{
			get => GetProperty(ref _craftingFill);
			set => SetProperty(ref _craftingFill, value);
		}

		[Ordinal(2)] 
		[RED("craftingLabel")] 
		public inkTextWidgetReference CraftingLabel
		{
			get => GetProperty(ref _craftingLabel);
			set => SetProperty(ref _craftingLabel, value);
		}

		[Ordinal(3)] 
		[RED("ButtonController")] 
		public wCHandle<inkButtonController> ButtonController
		{
			get => GetProperty(ref _buttonController);
			set => SetProperty(ref _buttonController, value);
		}

		[Ordinal(4)] 
		[RED("progressController")] 
		public wCHandle<ProgressBarsController> ProgressController
		{
			get => GetProperty(ref _progressController);
			set => SetProperty(ref _progressController, value);
		}

		[Ordinal(5)] 
		[RED("available")] 
		public CBool Available
		{
			get => GetProperty(ref _available);
			set => SetProperty(ref _available, value);
		}

		[Ordinal(6)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get => GetProperty(ref _progress);
			set => SetProperty(ref _progress, value);
		}

		public ProgressBarButton(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
