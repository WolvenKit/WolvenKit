using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICombatSquadTacticRatio : CVariable
	{
		private CFloat _ratioSum;
		private CFloat _reachSum;
		private CFloat _area;

		[Ordinal(0)] 
		[RED("ratioSum")] 
		public CFloat RatioSum
		{
			get => GetProperty(ref _ratioSum);
			set => SetProperty(ref _ratioSum, value);
		}

		[Ordinal(1)] 
		[RED("reachSum")] 
		public CFloat ReachSum
		{
			get => GetProperty(ref _reachSum);
			set => SetProperty(ref _reachSum, value);
		}

		[Ordinal(2)] 
		[RED("area")] 
		public CFloat Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		public AICombatSquadTacticRatio(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
