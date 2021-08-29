using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIActionTargetStates : RedBaseClass
	{
		private AIActionNPCStates _npcStates;
		private AIActionPlayerStates _playerStates;

		[Ordinal(0)] 
		[RED("npcStates")] 
		public AIActionNPCStates NpcStates
		{
			get => GetProperty(ref _npcStates);
			set => SetProperty(ref _npcStates, value);
		}

		[Ordinal(1)] 
		[RED("playerStates")] 
		public AIActionPlayerStates PlayerStates
		{
			get => GetProperty(ref _playerStates);
			set => SetProperty(ref _playerStates, value);
		}
	}
}
