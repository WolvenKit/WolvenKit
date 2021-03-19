using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChatterLineLogicController : BaseSubtitleLineLogicController
	{
		private inkWidgetReference _textContainer;
		private inkWidgetReference _speachBubble;
		private inkRectangleWidgetReference _background;
		private inkWidgetReference _container_normal;
		private inkWidgetReference _container_wide;
		private inkTextWidgetReference _text_normal;
		private inkTextWidgetReference _text_wide;
		private CHandle<inkTextKiroshiAnimationController> _kiroshiAnimationCtrl_Normal;
		private CHandle<inkTextKiroshiAnimationController> _kiroshiAnimationCtrl_Wide;
		private CHandle<inkTextMotherTongueController> _motherTongueCtrl_Normal;
		private CHandle<inkTextMotherTongueController> _motherTongueCtrl_Wide;
		private CBool _isNameplateVisible;
		private entEntityID _nameplateEntityId;
		private CFloat _nameplatHeightOffset;
		private entEntityID _ownerId;
		private CInt32 _c_ExtraWideTextWidth;
		private wCHandle<inkWidget> _rootWidget;
		private CHandle<inkScreenProjection> _projection;
		private CFloat _subtitlesMaxDistance;
		private CBool _limitSubtitlesDistance;

		[Ordinal(5)] 
		[RED("TextContainer")] 
		public inkWidgetReference TextContainer
		{
			get => GetProperty(ref _textContainer);
			set => SetProperty(ref _textContainer, value);
		}

		[Ordinal(6)] 
		[RED("speachBubble")] 
		public inkWidgetReference SpeachBubble
		{
			get => GetProperty(ref _speachBubble);
			set => SetProperty(ref _speachBubble, value);
		}

		[Ordinal(7)] 
		[RED("background")] 
		public inkRectangleWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(8)] 
		[RED("container_normal")] 
		public inkWidgetReference Container_normal
		{
			get => GetProperty(ref _container_normal);
			set => SetProperty(ref _container_normal, value);
		}

		[Ordinal(9)] 
		[RED("container_wide")] 
		public inkWidgetReference Container_wide
		{
			get => GetProperty(ref _container_wide);
			set => SetProperty(ref _container_wide, value);
		}

		[Ordinal(10)] 
		[RED("text_normal")] 
		public inkTextWidgetReference Text_normal
		{
			get => GetProperty(ref _text_normal);
			set => SetProperty(ref _text_normal, value);
		}

		[Ordinal(11)] 
		[RED("text_wide")] 
		public inkTextWidgetReference Text_wide
		{
			get => GetProperty(ref _text_wide);
			set => SetProperty(ref _text_wide, value);
		}

		[Ordinal(12)] 
		[RED("kiroshiAnimationCtrl_Normal")] 
		public CHandle<inkTextKiroshiAnimationController> KiroshiAnimationCtrl_Normal
		{
			get => GetProperty(ref _kiroshiAnimationCtrl_Normal);
			set => SetProperty(ref _kiroshiAnimationCtrl_Normal, value);
		}

		[Ordinal(13)] 
		[RED("kiroshiAnimationCtrl_Wide")] 
		public CHandle<inkTextKiroshiAnimationController> KiroshiAnimationCtrl_Wide
		{
			get => GetProperty(ref _kiroshiAnimationCtrl_Wide);
			set => SetProperty(ref _kiroshiAnimationCtrl_Wide, value);
		}

		[Ordinal(14)] 
		[RED("motherTongueCtrl_Normal")] 
		public CHandle<inkTextMotherTongueController> MotherTongueCtrl_Normal
		{
			get => GetProperty(ref _motherTongueCtrl_Normal);
			set => SetProperty(ref _motherTongueCtrl_Normal, value);
		}

		[Ordinal(15)] 
		[RED("motherTongueCtrl_Wide")] 
		public CHandle<inkTextMotherTongueController> MotherTongueCtrl_Wide
		{
			get => GetProperty(ref _motherTongueCtrl_Wide);
			set => SetProperty(ref _motherTongueCtrl_Wide, value);
		}

		[Ordinal(16)] 
		[RED("isNameplateVisible")] 
		public CBool IsNameplateVisible
		{
			get => GetProperty(ref _isNameplateVisible);
			set => SetProperty(ref _isNameplateVisible, value);
		}

		[Ordinal(17)] 
		[RED("nameplateEntityId")] 
		public entEntityID NameplateEntityId
		{
			get => GetProperty(ref _nameplateEntityId);
			set => SetProperty(ref _nameplateEntityId, value);
		}

		[Ordinal(18)] 
		[RED("nameplatHeightOffset")] 
		public CFloat NameplatHeightOffset
		{
			get => GetProperty(ref _nameplatHeightOffset);
			set => SetProperty(ref _nameplatHeightOffset, value);
		}

		[Ordinal(19)] 
		[RED("ownerId")] 
		public entEntityID OwnerId
		{
			get => GetProperty(ref _ownerId);
			set => SetProperty(ref _ownerId, value);
		}

		[Ordinal(20)] 
		[RED("c_ExtraWideTextWidth")] 
		public CInt32 C_ExtraWideTextWidth
		{
			get => GetProperty(ref _c_ExtraWideTextWidth);
			set => SetProperty(ref _c_ExtraWideTextWidth, value);
		}

		[Ordinal(21)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(22)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetProperty(ref _projection);
			set => SetProperty(ref _projection, value);
		}

		[Ordinal(23)] 
		[RED("subtitlesMaxDistance")] 
		public CFloat SubtitlesMaxDistance
		{
			get => GetProperty(ref _subtitlesMaxDistance);
			set => SetProperty(ref _subtitlesMaxDistance, value);
		}

		[Ordinal(24)] 
		[RED("limitSubtitlesDistance")] 
		public CBool LimitSubtitlesDistance
		{
			get => GetProperty(ref _limitSubtitlesDistance);
			set => SetProperty(ref _limitSubtitlesDistance, value);
		}

		public ChatterLineLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
