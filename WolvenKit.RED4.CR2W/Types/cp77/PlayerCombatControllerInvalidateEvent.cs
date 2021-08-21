using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerCombatControllerInvalidateEvent : redEvent
	{
		private CEnum<PlayerCombatState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<PlayerCombatState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public PlayerCombatControllerInvalidateEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
