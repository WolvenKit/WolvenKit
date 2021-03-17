using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDistanceToExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CHandle<AIbehaviorExpressionSocket> _target;
		private CFloat _tolerance;
		private CFloat _updatePeriod;

		[Ordinal(0)] 
		[RED("target")] 
		public CHandle<AIbehaviorExpressionSocket> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("tolerance")] 
		public CFloat Tolerance
		{
			get => GetProperty(ref _tolerance);
			set => SetProperty(ref _tolerance, value);
		}

		[Ordinal(2)] 
		[RED("updatePeriod")] 
		public CFloat UpdatePeriod
		{
			get => GetProperty(ref _updatePeriod);
			set => SetProperty(ref _updatePeriod, value);
		}

		public AIbehaviorDistanceToExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
