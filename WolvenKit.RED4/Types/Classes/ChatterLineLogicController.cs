using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChatterLineLogicController : BaseSubtitleLineLogicController
	{
		[Ordinal(5)] 
		[RED("TextContainer")] 
		public inkWidgetReference TextContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("speachBubble")] 
		public inkWidgetReference SpeachBubble
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("background")] 
		public inkRectangleWidgetReference Background
		{
			get => GetPropertyValue<inkRectangleWidgetReference>();
			set => SetPropertyValue<inkRectangleWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("container_normal")] 
		public inkWidgetReference Container_normal
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("container_wide")] 
		public inkWidgetReference Container_wide
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("text_normal")] 
		public inkTextWidgetReference Text_normal
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("text_wide")] 
		public inkTextWidgetReference Text_wide
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("kiroshiAnimationCtrl_Normal")] 
		public CWeakHandle<inkTextKiroshiAnimationController> KiroshiAnimationCtrl_Normal
		{
			get => GetPropertyValue<CWeakHandle<inkTextKiroshiAnimationController>>();
			set => SetPropertyValue<CWeakHandle<inkTextKiroshiAnimationController>>(value);
		}

		[Ordinal(13)] 
		[RED("kiroshiAnimationCtrl_Wide")] 
		public CWeakHandle<inkTextKiroshiAnimationController> KiroshiAnimationCtrl_Wide
		{
			get => GetPropertyValue<CWeakHandle<inkTextKiroshiAnimationController>>();
			set => SetPropertyValue<CWeakHandle<inkTextKiroshiAnimationController>>(value);
		}

		[Ordinal(14)] 
		[RED("motherTongueCtrl_Normal")] 
		public CWeakHandle<inkTextMotherTongueController> MotherTongueCtrl_Normal
		{
			get => GetPropertyValue<CWeakHandle<inkTextMotherTongueController>>();
			set => SetPropertyValue<CWeakHandle<inkTextMotherTongueController>>(value);
		}

		[Ordinal(15)] 
		[RED("motherTongueCtrl_Wide")] 
		public CWeakHandle<inkTextMotherTongueController> MotherTongueCtrl_Wide
		{
			get => GetPropertyValue<CWeakHandle<inkTextMotherTongueController>>();
			set => SetPropertyValue<CWeakHandle<inkTextMotherTongueController>>(value);
		}

		[Ordinal(16)] 
		[RED("isNameplateVisible")] 
		public CBool IsNameplateVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("nameplateEntityId")] 
		public entEntityID NameplateEntityId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(18)] 
		[RED("nameplatHeightOffset")] 
		public CFloat NameplatHeightOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("ownerId")] 
		public entEntityID OwnerId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(20)] 
		[RED("c_ExtraWideTextWidth")] 
		public CInt32 C_ExtraWideTextWidth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(21)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(22)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetPropertyValue<CHandle<inkScreenProjection>>();
			set => SetPropertyValue<CHandle<inkScreenProjection>>(value);
		}

		[Ordinal(23)] 
		[RED("subtitlesMaxDistance")] 
		public CFloat SubtitlesMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("bubbleMinDistance")] 
		public CFloat BubbleMinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("limitSubtitlesDistance")] 
		public CBool LimitSubtitlesDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("isOverHead")] 
		public CBool IsOverHead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ChatterLineLogicController()
		{
			TextContainer = new inkWidgetReference();
			SpeachBubble = new inkWidgetReference();
			Background = new inkRectangleWidgetReference();
			Container_normal = new inkWidgetReference();
			Container_wide = new inkWidgetReference();
			Text_normal = new inkTextWidgetReference();
			Text_wide = new inkTextWidgetReference();
			NameplateEntityId = new entEntityID();
			OwnerId = new entEntityID();
			C_ExtraWideTextWidth = 110;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
