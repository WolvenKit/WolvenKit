using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIThreatCalculationEvent : redEvent
	{
		private CBool _set;
		private CEnum<EAIThreatCalculationType> _temporaryThreatCalculationType;

		[Ordinal(0)] 
		[RED("set")] 
		public CBool Set
		{
			get => GetProperty(ref _set);
			set => SetProperty(ref _set, value);
		}

		[Ordinal(1)] 
		[RED("temporaryThreatCalculationType")] 
		public CEnum<EAIThreatCalculationType> TemporaryThreatCalculationType
		{
			get => GetProperty(ref _temporaryThreatCalculationType);
			set => SetProperty(ref _temporaryThreatCalculationType, value);
		}

		public AIThreatCalculationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
