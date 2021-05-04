using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterFleeingNPC : gameScriptableSystemRequest
	{
		private wCHandle<entEntity> _runner;
		private CFloat _timestamp;

		[Ordinal(0)] 
		[RED("runner")] 
		public wCHandle<entEntity> Runner
		{
			get => GetProperty(ref _runner);
			set => SetProperty(ref _runner, value);
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public CFloat Timestamp
		{
			get => GetProperty(ref _timestamp);
			set => SetProperty(ref _timestamp, value);
		}

		public RegisterFleeingNPC(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
