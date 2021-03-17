using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAvoidThreatTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _threatObject;
		private CHandle<AIArgumentMapping> _threatRadius;

		[Ordinal(1)] 
		[RED("threatObject")] 
		public CHandle<AIArgumentMapping> ThreatObject
		{
			get => GetProperty(ref _threatObject);
			set => SetProperty(ref _threatObject, value);
		}

		[Ordinal(2)] 
		[RED("threatRadius")] 
		public CHandle<AIArgumentMapping> ThreatRadius
		{
			get => GetProperty(ref _threatRadius);
			set => SetProperty(ref _threatRadius, value);
		}

		public AIbehaviorAvoidThreatTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
