using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolSpentPrereqListener : BaseStatPoolPrereqListener
	{
		private wCHandle<StatPoolSpentPrereqState> _state;
		private CFloat _overallSpentValue;

		[Ordinal(0)] 
		[RED("state")] 
		public wCHandle<StatPoolSpentPrereqState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("overallSpentValue")] 
		public CFloat OverallSpentValue
		{
			get => GetProperty(ref _overallSpentValue);
			set => SetProperty(ref _overallSpentValue, value);
		}

		public StatPoolSpentPrereqListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
