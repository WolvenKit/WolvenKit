using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimateAnchorOnHoverView : inkWidgetLogicController
	{
		private inkWidgetReference _raycaster;
		private CHandle<inkanimProxy> _animProxy;
		private Vector2 _hoverAnchor;
		private Vector2 _normalAnchor;
		private CFloat _animTime;

		[Ordinal(1)] 
		[RED("Raycaster")] 
		public inkWidgetReference Raycaster
		{
			get => GetProperty(ref _raycaster);
			set => SetProperty(ref _raycaster, value);
		}

		[Ordinal(2)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(3)] 
		[RED("HoverAnchor")] 
		public Vector2 HoverAnchor
		{
			get => GetProperty(ref _hoverAnchor);
			set => SetProperty(ref _hoverAnchor, value);
		}

		[Ordinal(4)] 
		[RED("NormalAnchor")] 
		public Vector2 NormalAnchor
		{
			get => GetProperty(ref _normalAnchor);
			set => SetProperty(ref _normalAnchor, value);
		}

		[Ordinal(5)] 
		[RED("AnimTime")] 
		public CFloat AnimTime
		{
			get => GetProperty(ref _animTime);
			set => SetProperty(ref _animTime, value);
		}

		public AnimateAnchorOnHoverView(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
