using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HUDProgressBarController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("barExtra")] 
		public inkWidgetReference BarExtra
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("header")] 
		public inkTextWidgetReference Header
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("bottomText")] 
		public inkTextWidgetReference BottomText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("percent")] 
		public inkTextWidgetReference Percent
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("completed")] 
		public inkTextWidgetReference Completed
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("failed")] 
		public inkTextWidgetReference Failed
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("attencionIcon")] 
		public inkWidgetReference AttencionIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("neutralIcon")] 
		public inkWidgetReference NeutralIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("relicIcon")] 
		public inkWidgetReference RelicIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("moneyIcon")] 
		public inkWidgetReference MoneyIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("apartmentIcon")] 
		public inkImageWidgetReference ApartmentIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("vehicleIcon")] 
		public inkImageWidgetReference VehicleIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("neutralInIcon")] 
		public inkImageWidgetReference NeutralInIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("revealIcon")] 
		public inkWidgetReference RevealIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("vahicleHackIcon")] 
		public inkWidgetReference VahicleHackIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(27)] 
		[RED("progressBarBB")] 
		public CWeakHandle<gameIBlackboard> ProgressBarBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(28)] 
		[RED("progressBarDef")] 
		public CHandle<UI_HUDProgressBarDef> ProgressBarDef
		{
			get => GetPropertyValue<CHandle<UI_HUDProgressBarDef>>();
			set => SetPropertyValue<CHandle<UI_HUDProgressBarDef>>(value);
		}

		[Ordinal(29)] 
		[RED("activeBBID")] 
		public CHandle<redCallbackObject> ActiveBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(30)] 
		[RED("headerBBID")] 
		public CHandle<redCallbackObject> HeaderBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("typeBBID")] 
		public CHandle<redCallbackObject> TypeBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(32)] 
		[RED("bottomTextBBID")] 
		public CHandle<redCallbackObject> BottomTextBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(33)] 
		[RED("completedTextBBID")] 
		public CHandle<redCallbackObject> CompletedTextBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(34)] 
		[RED("failedTextBBID")] 
		public CHandle<redCallbackObject> FailedTextBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(35)] 
		[RED("progressBBID")] 
		public CHandle<redCallbackObject> ProgressBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(36)] 
		[RED("progressBumpBBID")] 
		public CHandle<redCallbackObject> ProgressBumpBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(37)] 
		[RED("bb")] 
		public CWeakHandle<gameIBlackboard> Bb
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(38)] 
		[RED("bbUIInteractionsDef")] 
		public CHandle<UIInteractionsDef> BbUIInteractionsDef
		{
			get => GetPropertyValue<CHandle<UIInteractionsDef>>();
			set => SetPropertyValue<CHandle<UIInteractionsDef>>(value);
		}

		[Ordinal(39)] 
		[RED("bbChoiceHubDataCallbackId")] 
		public CHandle<redCallbackObject> BbChoiceHubDataCallbackId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(40)] 
		[RED("OutroAnimation")] 
		public CHandle<inkanimProxy> OutroAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(41)] 
		[RED("LoopAnimation")] 
		public CHandle<inkanimProxy> LoopAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(42)] 
		[RED("VLoopAnimation")] 
		public CHandle<inkanimProxy> VLoopAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(43)] 
		[RED("IntroAnimation")] 
		public CHandle<inkanimProxy> IntroAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(44)] 
		[RED("IntroWasPlayed")] 
		public CBool IntroWasPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(46)] 
		[RED("type")] 
		public CEnum<gameSimpleMessageType> Type
		{
			get => GetPropertyValue<CEnum<gameSimpleMessageType>>();
			set => SetPropertyValue<CEnum<gameSimpleMessageType>>(value);
		}

		[Ordinal(47)] 
		[RED("valueSaved")] 
		public CFloat ValueSaved
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(48)] 
		[RED("bumpValue")] 
		public CFloat BumpValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public HUDProgressBarController()
		{
			Bar = new inkWidgetReference();
			BarExtra = new inkWidgetReference();
			Header = new inkTextWidgetReference();
			BottomText = new inkTextWidgetReference();
			Percent = new inkTextWidgetReference();
			Completed = new inkTextWidgetReference();
			Failed = new inkTextWidgetReference();
			AttencionIcon = new inkWidgetReference();
			NeutralIcon = new inkWidgetReference();
			RelicIcon = new inkWidgetReference();
			MoneyIcon = new inkWidgetReference();
			ApartmentIcon = new inkImageWidgetReference();
			VehicleIcon = new inkImageWidgetReference();
			NeutralInIcon = new inkImageWidgetReference();
			RevealIcon = new inkWidgetReference();
			VahicleHackIcon = new inkWidgetReference();
			Wrapper = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
