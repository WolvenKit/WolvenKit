using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("BlackboardSystem")] 
		public CHandle<gameBlackboardSystem> BlackboardSystem
		{
			get => GetPropertyValue<CHandle<gameBlackboardSystem>>();
			set => SetPropertyValue<CHandle<gameBlackboardSystem>>(value);
		}

		[Ordinal(1)] 
		[RED("Blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(2)] 
		[RED("LastCallInformation")] 
		public questPhoneCallInformation LastCallInformation
		{
			get => GetPropertyValue<questPhoneCallInformation>();
			set => SetPropertyValue<questPhoneCallInformation>(value);
		}

		[Ordinal(3)] 
		[RED("ContactsOpen")] 
		public CBool ContactsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("ContactsOpenBBId")] 
		public CHandle<redCallbackObject> ContactsOpenBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public PhoneSystem()
		{
			LastCallInformation = new questPhoneCallInformation();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
