using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetTargetLastKnownPosition : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inTargetObject;
		private CHandle<AIArgumentMapping> _outPosition;
		private CFloat _predictionTime;

		[Ordinal(0)] 
		[RED("inTargetObject")] 
		public CHandle<AIArgumentMapping> InTargetObject
		{
			get => GetProperty(ref _inTargetObject);
			set => SetProperty(ref _inTargetObject, value);
		}

		[Ordinal(1)] 
		[RED("outPosition")] 
		public CHandle<AIArgumentMapping> OutPosition
		{
			get => GetProperty(ref _outPosition);
			set => SetProperty(ref _outPosition, value);
		}

		[Ordinal(2)] 
		[RED("predictionTime")] 
		public CFloat PredictionTime
		{
			get => GetProperty(ref _predictionTime);
			set => SetProperty(ref _predictionTime, value);
		}

		public GetTargetLastKnownPosition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
