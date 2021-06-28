using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SendInstructionRequest : gameScriptableSystemRequest
	{
		private CArray<HUDJob> _jobs;

		[Ordinal(0)] 
		[RED("jobs")] 
		public CArray<HUDJob> Jobs
		{
			get => GetProperty(ref _jobs);
			set => SetProperty(ref _jobs, value);
		}

		public SendInstructionRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
