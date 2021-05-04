using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeJuryrigTrapState : redEvent
	{
		private CEnum<EJuryrigTrapState> _newState;

		[Ordinal(0)] 
		[RED("newState")] 
		public CEnum<EJuryrigTrapState> NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}

		public ChangeJuryrigTrapState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
