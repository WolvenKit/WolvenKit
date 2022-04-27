using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GenericNotificationController : gameuiGenericNotificationReceiverGameController
	{
		[Ordinal(3)] 
		[RED("titleRef")] 
		public inkTextWidgetReference TitleRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("textRef")] 
		public inkTextWidgetReference TextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("actionLabelRef")] 
		public inkTextWidgetReference ActionLabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("actionRef")] 
		public inkWidgetReference ActionRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("blockAction")] 
		public CBool BlockAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("translationAnimationCtrl")] 
		public CWeakHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get => GetPropertyValue<CWeakHandle<inkTextReplaceAnimationController>>();
			set => SetPropertyValue<CWeakHandle<inkTextReplaceAnimationController>>(value);
		}

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<gameuiGenericNotificationViewData> Data
		{
			get => GetPropertyValue<CHandle<gameuiGenericNotificationViewData>>();
			set => SetPropertyValue<CHandle<gameuiGenericNotificationViewData>>(value);
		}

		[Ordinal(10)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(11)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GenericNotificationController()
		{
			TitleRef = new();
			TextRef = new();
			ActionLabelRef = new();
			ActionRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
