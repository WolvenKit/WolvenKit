using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HubMenuLabelController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _container;
		private wCHandle<inkWidget> _wrapper;
		private wCHandle<inkWidget> _wrapperNext;
		private wCHandle<HubMenuLabelContentContainer> _wrapperController;
		private wCHandle<HubMenuLabelContentContainer> _wrapperNextController;
		private MenuData _data;
		private CBool _watchForSize;
		private CBool _watchForInstatnSize;
		private CBool _once;
		private CInt32 _direction;

		[Ordinal(1)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(2)] 
		[RED("wrapper")] 
		public wCHandle<inkWidget> Wrapper
		{
			get => GetProperty(ref _wrapper);
			set => SetProperty(ref _wrapper, value);
		}

		[Ordinal(3)] 
		[RED("wrapperNext")] 
		public wCHandle<inkWidget> WrapperNext
		{
			get => GetProperty(ref _wrapperNext);
			set => SetProperty(ref _wrapperNext, value);
		}

		[Ordinal(4)] 
		[RED("wrapperController")] 
		public wCHandle<HubMenuLabelContentContainer> WrapperController
		{
			get => GetProperty(ref _wrapperController);
			set => SetProperty(ref _wrapperController, value);
		}

		[Ordinal(5)] 
		[RED("wrapperNextController")] 
		public wCHandle<HubMenuLabelContentContainer> WrapperNextController
		{
			get => GetProperty(ref _wrapperNextController);
			set => SetProperty(ref _wrapperNextController, value);
		}

		[Ordinal(6)] 
		[RED("data")] 
		public MenuData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(7)] 
		[RED("watchForSize")] 
		public CBool WatchForSize
		{
			get => GetProperty(ref _watchForSize);
			set => SetProperty(ref _watchForSize, value);
		}

		[Ordinal(8)] 
		[RED("watchForInstatnSize")] 
		public CBool WatchForInstatnSize
		{
			get => GetProperty(ref _watchForInstatnSize);
			set => SetProperty(ref _watchForInstatnSize, value);
		}

		[Ordinal(9)] 
		[RED("once")] 
		public CBool Once
		{
			get => GetProperty(ref _once);
			set => SetProperty(ref _once, value);
		}

		[Ordinal(10)] 
		[RED("direction")] 
		public CInt32 Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		public HubMenuLabelController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
