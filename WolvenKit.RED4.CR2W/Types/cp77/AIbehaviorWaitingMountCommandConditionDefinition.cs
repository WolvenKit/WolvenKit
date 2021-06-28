using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorWaitingMountCommandConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _requestArgument;
		private CName _callbackName;

		[Ordinal(1)] 
		[RED("requestArgument")] 
		public CHandle<AIArgumentMapping> RequestArgument
		{
			get => GetProperty(ref _requestArgument);
			set => SetProperty(ref _requestArgument, value);
		}

		[Ordinal(2)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get => GetProperty(ref _callbackName);
			set => SetProperty(ref _callbackName, value);
		}

		public AIbehaviorWaitingMountCommandConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
