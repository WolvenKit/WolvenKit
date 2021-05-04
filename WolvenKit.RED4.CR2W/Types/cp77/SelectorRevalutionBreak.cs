using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SelectorRevalutionBreak : AIbehaviortaskScript
	{
		private CFloat _reevaluationDuration;
		private CFloat _activationTimeStamp;

		[Ordinal(0)] 
		[RED("reevaluationDuration")] 
		public CFloat ReevaluationDuration
		{
			get => GetProperty(ref _reevaluationDuration);
			set => SetProperty(ref _reevaluationDuration, value);
		}

		[Ordinal(1)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetProperty(ref _activationTimeStamp);
			set => SetProperty(ref _activationTimeStamp, value);
		}

		public SelectorRevalutionBreak(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
