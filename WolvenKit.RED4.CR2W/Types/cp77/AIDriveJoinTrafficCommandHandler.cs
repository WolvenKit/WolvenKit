using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDriveJoinTrafficCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outUseKinematic;
		private CHandle<AIArgumentMapping> _outNeedDriver;

		[Ordinal(1)] 
		[RED("outUseKinematic")] 
		public CHandle<AIArgumentMapping> OutUseKinematic
		{
			get => GetProperty(ref _outUseKinematic);
			set => SetProperty(ref _outUseKinematic, value);
		}

		[Ordinal(2)] 
		[RED("outNeedDriver")] 
		public CHandle<AIArgumentMapping> OutNeedDriver
		{
			get => GetProperty(ref _outNeedDriver);
			set => SetProperty(ref _outNeedDriver, value);
		}

		public AIDriveJoinTrafficCommandHandler(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
