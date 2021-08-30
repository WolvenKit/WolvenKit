using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInputActionRangedAttack : gameIMuppetInputAction
	{
		private CEnum<gameMuppetInputActionType> _actionType;

		[Ordinal(0)] 
		[RED("actionType")] 
		public CEnum<gameMuppetInputActionType> ActionType
		{
			get => GetProperty(ref _actionType);
			set => SetProperty(ref _actionType, value);
		}

		public gameMuppetInputActionRangedAttack()
		{
			_actionType = new() { Value = Enums.gameMuppetInputActionType.Press };
		}
	}
}
