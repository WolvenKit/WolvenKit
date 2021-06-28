using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SearchPatternMappingLookat : AISearchingLookat
	{
		private CHandle<AIArgumentMapping> _targetObjectMapping;
		private wCHandle<gameObject> _lookatTargetObject;

		[Ordinal(14)] 
		[RED("targetObjectMapping")] 
		public CHandle<AIArgumentMapping> TargetObjectMapping
		{
			get => GetProperty(ref _targetObjectMapping);
			set => SetProperty(ref _targetObjectMapping, value);
		}

		[Ordinal(15)] 
		[RED("lookatTargetObject")] 
		public wCHandle<gameObject> LookatTargetObject
		{
			get => GetProperty(ref _lookatTargetObject);
			set => SetProperty(ref _lookatTargetObject, value);
		}

		public SearchPatternMappingLookat(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
