using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrouchDecisions : LocomotionGroundDecisions
	{
		private wCHandle<GameplaySettingsSystem> _gameplaySettings;
		private wCHandle<gameObject> _executionOwner;
		private CHandle<redCallbackObject> _callbackID;
		private CHandle<DefaultTransitionStatusEffectListener> _statusEffectListener;
		private CBool _crouchPressed;
		private CBool _toggleCrouchPressed;
		private CBool _forcedCrouch;
		private CBool _controllingDevice;

		[Ordinal(3)] 
		[RED("gameplaySettings")] 
		public wCHandle<GameplaySettingsSystem> GameplaySettings
		{
			get => GetProperty(ref _gameplaySettings);
			set => SetProperty(ref _gameplaySettings, value);
		}

		[Ordinal(4)] 
		[RED("executionOwner")] 
		public wCHandle<gameObject> ExecutionOwner
		{
			get => GetProperty(ref _executionOwner);
			set => SetProperty(ref _executionOwner, value);
		}

		[Ordinal(5)] 
		[RED("callbackID")] 
		public CHandle<redCallbackObject> CallbackID
		{
			get => GetProperty(ref _callbackID);
			set => SetProperty(ref _callbackID, value);
		}

		[Ordinal(6)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetProperty(ref _statusEffectListener);
			set => SetProperty(ref _statusEffectListener, value);
		}

		[Ordinal(7)] 
		[RED("crouchPressed")] 
		public CBool CrouchPressed
		{
			get => GetProperty(ref _crouchPressed);
			set => SetProperty(ref _crouchPressed, value);
		}

		[Ordinal(8)] 
		[RED("toggleCrouchPressed")] 
		public CBool ToggleCrouchPressed
		{
			get => GetProperty(ref _toggleCrouchPressed);
			set => SetProperty(ref _toggleCrouchPressed, value);
		}

		[Ordinal(9)] 
		[RED("forcedCrouch")] 
		public CBool ForcedCrouch
		{
			get => GetProperty(ref _forcedCrouch);
			set => SetProperty(ref _forcedCrouch, value);
		}

		[Ordinal(10)] 
		[RED("controllingDevice")] 
		public CBool ControllingDevice
		{
			get => GetProperty(ref _controllingDevice);
			set => SetProperty(ref _controllingDevice, value);
		}

		public CrouchDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
