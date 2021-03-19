using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayContainerController : inkWidgetLogicController
	{
		private CInt32 _index;
		private CBool _isTrait;
		private inkWidgetReference _widget;
		private CHandle<BasePerkDisplayData> _data;
		private CHandle<PlayerDevelopmentDataManager> _dataManager;
		private CHandle<PerkDisplayController> _controller;

		[Ordinal(1)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(2)] 
		[RED("isTrait")] 
		public CBool IsTrait
		{
			get => GetProperty(ref _isTrait);
			set => SetProperty(ref _isTrait, value);
		}

		[Ordinal(3)] 
		[RED("widget")] 
		public inkWidgetReference Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<BasePerkDisplayData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(5)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(6)] 
		[RED("controller")] 
		public CHandle<PerkDisplayController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		public PerkDisplayContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
