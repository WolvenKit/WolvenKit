using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetSecuritySystemState : redEvent
	{
		private CEnum<ESecuritySystemState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<ESecuritySystemState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public SetSecuritySystemState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
