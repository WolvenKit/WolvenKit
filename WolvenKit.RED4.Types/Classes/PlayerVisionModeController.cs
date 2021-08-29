using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerVisionModeController : IScriptable
	{
		private PlayerVisionModeControllerRefreshPolicy _gameplayActiveFlagsRefreshPolicy;
		private PlayerVisionModeControllerBBIds _blackboardIds;
		private PlayerVisionModeControllerBBValuesIds _blackboardValuesIds;
		private PlayerVisionModeControllerBlackboardListenersFunctions _blackboardListenersFunctions;
		private PlayerVisionModeControllerBBListeners _blackboardListeners;
		private PlayerVisionModeControllerActiveFlags _gameplayActiveFlags;
		private PlayerVisionModeControllerInputActionsNames _inputActionsNames;
		private PlayerVisionModeControllerInputListeners _inputListeners;
		private PlayerVisionModeControllerInputActiveFlags _inputActiveFlags;
		private PlayerVisionModeControllerOtherVars _otherVars;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("gameplayActiveFlagsRefreshPolicy")] 
		public PlayerVisionModeControllerRefreshPolicy GameplayActiveFlagsRefreshPolicy
		{
			get => GetProperty(ref _gameplayActiveFlagsRefreshPolicy);
			set => SetProperty(ref _gameplayActiveFlagsRefreshPolicy, value);
		}

		[Ordinal(1)] 
		[RED("blackboardIds")] 
		public PlayerVisionModeControllerBBIds BlackboardIds
		{
			get => GetProperty(ref _blackboardIds);
			set => SetProperty(ref _blackboardIds, value);
		}

		[Ordinal(2)] 
		[RED("blackboardValuesIds")] 
		public PlayerVisionModeControllerBBValuesIds BlackboardValuesIds
		{
			get => GetProperty(ref _blackboardValuesIds);
			set => SetProperty(ref _blackboardValuesIds, value);
		}

		[Ordinal(3)] 
		[RED("blackboardListenersFunctions")] 
		public PlayerVisionModeControllerBlackboardListenersFunctions BlackboardListenersFunctions
		{
			get => GetProperty(ref _blackboardListenersFunctions);
			set => SetProperty(ref _blackboardListenersFunctions, value);
		}

		[Ordinal(4)] 
		[RED("blackboardListeners")] 
		public PlayerVisionModeControllerBBListeners BlackboardListeners
		{
			get => GetProperty(ref _blackboardListeners);
			set => SetProperty(ref _blackboardListeners, value);
		}

		[Ordinal(5)] 
		[RED("gameplayActiveFlags")] 
		public PlayerVisionModeControllerActiveFlags GameplayActiveFlags
		{
			get => GetProperty(ref _gameplayActiveFlags);
			set => SetProperty(ref _gameplayActiveFlags, value);
		}

		[Ordinal(6)] 
		[RED("inputActionsNames")] 
		public PlayerVisionModeControllerInputActionsNames InputActionsNames
		{
			get => GetProperty(ref _inputActionsNames);
			set => SetProperty(ref _inputActionsNames, value);
		}

		[Ordinal(7)] 
		[RED("inputListeners")] 
		public PlayerVisionModeControllerInputListeners InputListeners
		{
			get => GetProperty(ref _inputListeners);
			set => SetProperty(ref _inputListeners, value);
		}

		[Ordinal(8)] 
		[RED("inputActiveFlags")] 
		public PlayerVisionModeControllerInputActiveFlags InputActiveFlags
		{
			get => GetProperty(ref _inputActiveFlags);
			set => SetProperty(ref _inputActiveFlags, value);
		}

		[Ordinal(9)] 
		[RED("otherVars")] 
		public PlayerVisionModeControllerOtherVars OtherVars
		{
			get => GetProperty(ref _otherVars);
			set => SetProperty(ref _otherVars, value);
		}

		[Ordinal(10)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
