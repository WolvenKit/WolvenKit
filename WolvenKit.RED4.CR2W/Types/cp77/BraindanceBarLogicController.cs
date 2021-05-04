using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BraindanceBarLogicController : inkWidgetLogicController
	{
		private CEnum<gameuiEBraindanceLayer> _layer;
		private CBool _isInLayer;
		private CName _timelineActiveAnimationName;
		private CName _timelineDisabledAnimationName;
		private CHandle<inkanimProxy> _timelineActiveAnimation;
		private CHandle<inkanimProxy> _timelineDisabledAnimation;

		[Ordinal(1)] 
		[RED("layer")] 
		public CEnum<gameuiEBraindanceLayer> Layer
		{
			get => GetProperty(ref _layer);
			set => SetProperty(ref _layer, value);
		}

		[Ordinal(2)] 
		[RED("isInLayer")] 
		public CBool IsInLayer
		{
			get => GetProperty(ref _isInLayer);
			set => SetProperty(ref _isInLayer, value);
		}

		[Ordinal(3)] 
		[RED("timelineActiveAnimationName")] 
		public CName TimelineActiveAnimationName
		{
			get => GetProperty(ref _timelineActiveAnimationName);
			set => SetProperty(ref _timelineActiveAnimationName, value);
		}

		[Ordinal(4)] 
		[RED("timelineDisabledAnimationName")] 
		public CName TimelineDisabledAnimationName
		{
			get => GetProperty(ref _timelineDisabledAnimationName);
			set => SetProperty(ref _timelineDisabledAnimationName, value);
		}

		[Ordinal(5)] 
		[RED("timelineActiveAnimation")] 
		public CHandle<inkanimProxy> TimelineActiveAnimation
		{
			get => GetProperty(ref _timelineActiveAnimation);
			set => SetProperty(ref _timelineActiveAnimation, value);
		}

		[Ordinal(6)] 
		[RED("timelineDisabledAnimation")] 
		public CHandle<inkanimProxy> TimelineDisabledAnimation
		{
			get => GetProperty(ref _timelineDisabledAnimation);
			set => SetProperty(ref _timelineDisabledAnimation, value);
		}

		public BraindanceBarLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
