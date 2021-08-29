using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhoneSystem : gameScriptableSystem
	{
		private CHandle<gameBlackboardSystem> _blackboardSystem;
		private CWeakHandle<gameIBlackboard> _blackboard;
		private questPhoneCallInformation _lastCallInformation;
		private CBool _contactsOpen;
		private CHandle<redCallbackObject> _contactsOpenBBId;

		[Ordinal(0)] 
		[RED("BlackboardSystem")] 
		public CHandle<gameBlackboardSystem> BlackboardSystem
		{
			get => GetProperty(ref _blackboardSystem);
			set => SetProperty(ref _blackboardSystem, value);
		}

		[Ordinal(1)] 
		[RED("Blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(2)] 
		[RED("LastCallInformation")] 
		public questPhoneCallInformation LastCallInformation
		{
			get => GetProperty(ref _lastCallInformation);
			set => SetProperty(ref _lastCallInformation, value);
		}

		[Ordinal(3)] 
		[RED("ContactsOpen")] 
		public CBool ContactsOpen
		{
			get => GetProperty(ref _contactsOpen);
			set => SetProperty(ref _contactsOpen, value);
		}

		[Ordinal(4)] 
		[RED("ContactsOpenBBId")] 
		public CHandle<redCallbackObject> ContactsOpenBBId
		{
			get => GetProperty(ref _contactsOpenBBId);
			set => SetProperty(ref _contactsOpenBBId, value);
		}
	}
}
