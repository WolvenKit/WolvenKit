using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckThreat : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _targetObjectMapping;
		private wCHandle<gameObject> _targetThreat;

		[Ordinal(0)] 
		[RED("targetObjectMapping")] 
		public CHandle<AIArgumentMapping> TargetObjectMapping
		{
			get => GetProperty(ref _targetObjectMapping);
			set => SetProperty(ref _targetObjectMapping, value);
		}

		[Ordinal(1)] 
		[RED("targetThreat")] 
		public wCHandle<gameObject> TargetThreat
		{
			get => GetProperty(ref _targetThreat);
			set => SetProperty(ref _targetThreat, value);
		}

		public CheckThreat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
