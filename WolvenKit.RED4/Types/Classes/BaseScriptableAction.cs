using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseScriptableAction : gamedeviceAction
	{
		[Ordinal(3)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(4)] 
		[RED("executor")] 
		public CWeakHandle<gameObject> Executor
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(5)] 
		[RED("objectActionID")] 
		public TweakDBID ObjectActionID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(6)] 
		[RED("objectActionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>(value);
		}

		[Ordinal(7)] 
		[RED("inkWidgetID")] 
		public TweakDBID InkWidgetID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(8)] 
		[RED("interactionChoice")] 
		public gameinteractionsChoice InteractionChoice
		{
			get => GetPropertyValue<gameinteractionsChoice>();
			set => SetPropertyValue<gameinteractionsChoice>(value);
		}

		[Ordinal(9)] 
		[RED("interactionLayer")] 
		public CName InteractionLayer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("isActionRPGCheckDissabled")] 
		public CBool IsActionRPGCheckDissabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BaseScriptableAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
