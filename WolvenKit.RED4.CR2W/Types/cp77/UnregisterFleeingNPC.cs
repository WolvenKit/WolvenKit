using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterFleeingNPC : gameScriptableSystemRequest
	{
		private wCHandle<entEntity> _runner;

		[Ordinal(0)] 
		[RED("runner")] 
		public wCHandle<entEntity> Runner
		{
			get => GetProperty(ref _runner);
			set => SetProperty(ref _runner, value);
		}

		public UnregisterFleeingNPC(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
