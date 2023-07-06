using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShardNotificationController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("titleRef")] 
		public inkTextWidgetReference TitleRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("shortTextRef")] 
		public inkTextWidgetReference ShortTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("longTextRef")] 
		public inkTextWidgetReference LongTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("shortTextHolderRef")] 
		public inkWidgetReference ShortTextHolderRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("longTextHolderRef")] 
		public inkWidgetReference LongTextHolderRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("buttonHintsManagerParentRef")] 
		public inkWidgetReference ButtonHintsManagerParentRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("buttonHintsSecondaryManagerRef")] 
		public inkWidgetReference ButtonHintsSecondaryManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("buttonHintsSecondaryManagerParentRef")] 
		public inkWidgetReference ButtonHintsSecondaryManagerParentRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<ShardReadPopupData> Data
		{
			get => GetPropertyValue<CHandle<ShardReadPopupData>>();
			set => SetPropertyValue<CHandle<ShardReadPopupData>>(value);
		}

		[Ordinal(12)] 
		[RED("longTextTrashold")] 
		public CInt32 LongTextTrashold
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(14)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(15)] 
		[RED("mingameBB")] 
		public CWeakHandle<gameIBlackboard> MingameBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public ShardNotificationController()
		{
			TitleRef = new inkTextWidgetReference();
			ShortTextRef = new inkTextWidgetReference();
			LongTextRef = new inkTextWidgetReference();
			ShortTextHolderRef = new inkWidgetReference();
			LongTextHolderRef = new inkWidgetReference();
			ButtonHintsManagerRef = new inkWidgetReference();
			ButtonHintsManagerParentRef = new inkWidgetReference();
			ButtonHintsSecondaryManagerRef = new inkWidgetReference();
			ButtonHintsSecondaryManagerParentRef = new inkWidgetReference();
			LongTextTrashold = 1000;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
