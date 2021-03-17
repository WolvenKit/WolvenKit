using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNodeRefConverterTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _nodeRef;
		private CHandle<AIArgumentMapping> _result;

		[Ordinal(1)] 
		[RED("nodeRef")] 
		public CHandle<AIArgumentMapping> NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(2)] 
		[RED("result")] 
		public CHandle<AIArgumentMapping> Result
		{
			get => GetProperty(ref _result);
			set => SetProperty(ref _result, value);
		}

		public AIbehaviorNodeRefConverterTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
