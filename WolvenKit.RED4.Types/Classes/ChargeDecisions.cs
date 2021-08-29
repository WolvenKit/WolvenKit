using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChargeDecisions : WeaponTransition
	{
		private CHandle<redCallbackObject> _callbackID;
		private CBool _triggerModeCorrect;
		private CBool _inputPressed;

		[Ordinal(3)] 
		[RED("callbackID")] 
		public CHandle<redCallbackObject> CallbackID
		{
			get => GetProperty(ref _callbackID);
			set => SetProperty(ref _callbackID, value);
		}

		[Ordinal(4)] 
		[RED("triggerModeCorrect")] 
		public CBool TriggerModeCorrect
		{
			get => GetProperty(ref _triggerModeCorrect);
			set => SetProperty(ref _triggerModeCorrect, value);
		}

		[Ordinal(5)] 
		[RED("inputPressed")] 
		public CBool InputPressed
		{
			get => GetProperty(ref _inputPressed);
			set => SetProperty(ref _inputPressed, value);
		}
	}
}
