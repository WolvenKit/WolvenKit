using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTrackPatrolProgressNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _pathParameters;
		private CHandle<AIArgumentMapping> _patrolProgress;
		private CHandle<AIArgumentMapping> _startFromClosestPoint;

		[Ordinal(1)] 
		[RED("pathParameters")] 
		public CHandle<AIArgumentMapping> PathParameters
		{
			get => GetProperty(ref _pathParameters);
			set => SetProperty(ref _pathParameters, value);
		}

		[Ordinal(2)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get => GetProperty(ref _patrolProgress);
			set => SetProperty(ref _patrolProgress, value);
		}

		[Ordinal(3)] 
		[RED("startFromClosestPoint")] 
		public CHandle<AIArgumentMapping> StartFromClosestPoint
		{
			get => GetProperty(ref _startFromClosestPoint);
			set => SetProperty(ref _startFromClosestPoint, value);
		}

		public AIbehaviorTrackPatrolProgressNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
