using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveGlobalDeathCondition : AIbehaviorexpressionScript
	{
		private CUInt32 _onDeathCbId;

		[Ordinal(0)] 
		[RED("onDeathCbId")] 
		public CUInt32 OnDeathCbId
		{
			get => GetProperty(ref _onDeathCbId);
			set => SetProperty(ref _onDeathCbId, value);
		}

		public PassiveGlobalDeathCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
