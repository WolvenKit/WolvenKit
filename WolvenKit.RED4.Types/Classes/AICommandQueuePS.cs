using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICommandQueuePS : gameComponentPS
	{
		private CArray<CHandle<AIArgumentInstancePS>> _behaviorArgumentList;
		private CHandle<AIRole> _aiRole;

		[Ordinal(0)] 
		[RED("behaviorArgumentList")] 
		public CArray<CHandle<AIArgumentInstancePS>> BehaviorArgumentList
		{
			get => GetProperty(ref _behaviorArgumentList);
			set => SetProperty(ref _behaviorArgumentList, value);
		}

		[Ordinal(1)] 
		[RED("aiRole")] 
		public CHandle<AIRole> AiRole
		{
			get => GetProperty(ref _aiRole);
			set => SetProperty(ref _aiRole, value);
		}
	}
}
