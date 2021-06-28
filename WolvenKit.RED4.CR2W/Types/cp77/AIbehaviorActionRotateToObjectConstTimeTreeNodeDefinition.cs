using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionRotateToObjectConstTimeTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _angleOffset;
		private CHandle<AIArgumentMapping> _angleTolerance;
		private CHandle<AIArgumentMapping> _time;
		private CHandle<AIArgumentMapping> _keepUpdatingTarget;

		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("angleOffset")] 
		public CHandle<AIArgumentMapping> AngleOffset
		{
			get => GetProperty(ref _angleOffset);
			set => SetProperty(ref _angleOffset, value);
		}

		[Ordinal(3)] 
		[RED("angleTolerance")] 
		public CHandle<AIArgumentMapping> AngleTolerance
		{
			get => GetProperty(ref _angleTolerance);
			set => SetProperty(ref _angleTolerance, value);
		}

		[Ordinal(4)] 
		[RED("time")] 
		public CHandle<AIArgumentMapping> Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(5)] 
		[RED("keepUpdatingTarget")] 
		public CHandle<AIArgumentMapping> KeepUpdatingTarget
		{
			get => GetProperty(ref _keepUpdatingTarget);
			set => SetProperty(ref _keepUpdatingTarget, value);
		}

		public AIbehaviorActionRotateToObjectConstTimeTreeNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
