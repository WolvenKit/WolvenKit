using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPuppetRefToGameObjectTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _puppetRef;
		private CHandle<AIArgumentMapping> _result;

		[Ordinal(1)] 
		[RED("puppetRef")] 
		public CHandle<AIArgumentMapping> PuppetRef
		{
			get
			{
				if (_puppetRef == null)
				{
					_puppetRef = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "puppetRef", cr2w, this);
				}
				return _puppetRef;
			}
			set
			{
				if (_puppetRef == value)
				{
					return;
				}
				_puppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("result")] 
		public CHandle<AIArgumentMapping> Result
		{
			get
			{
				if (_result == null)
				{
					_result = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "result", cr2w, this);
				}
				return _result;
			}
			set
			{
				if (_result == value)
				{
					return;
				}
				_result = value;
				PropertySet(this);
			}
		}

		public AIbehaviorPuppetRefToGameObjectTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
