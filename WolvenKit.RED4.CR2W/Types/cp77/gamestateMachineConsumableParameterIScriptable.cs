using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineConsumableParameterIScriptable : gamestateMachineActionParameterIScriptable
	{
		private CBool _consumed;

		[Ordinal(2)] 
		[RED("consumed")] 
		public CBool Consumed
		{
			get => GetProperty(ref _consumed);
			set => SetProperty(ref _consumed, value);
		}

		public gamestateMachineConsumableParameterIScriptable(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
