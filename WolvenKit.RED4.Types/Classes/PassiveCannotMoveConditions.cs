using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PassiveCannotMoveConditions : PassiveAutonomousCondition
	{
		private CUInt32 _statusEffectRemovedId;

		[Ordinal(0)] 
		[RED("statusEffectRemovedId")] 
		public CUInt32 StatusEffectRemovedId
		{
			get => GetProperty(ref _statusEffectRemovedId);
			set => SetProperty(ref _statusEffectRemovedId, value);
		}
	}
}
