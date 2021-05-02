using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionTargetStates : CVariable
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

		public AIActionTargetStates(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
