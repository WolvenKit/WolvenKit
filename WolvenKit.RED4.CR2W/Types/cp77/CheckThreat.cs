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
			get
			{
				if (_targetObjectMapping == null)
				{
					_targetObjectMapping = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "targetObjectMapping", cr2w, this);
				}
				return _targetObjectMapping;
			}
			set
			{
				if (_targetObjectMapping == value)
				{
					return;
				}
				_targetObjectMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetThreat")] 
		public wCHandle<gameObject> TargetThreat
		{
			get
			{
				if (_targetThreat == null)
				{
					_targetThreat = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "targetThreat", cr2w, this);
				}
				return _targetThreat;
			}
			set
			{
				if (_targetThreat == value)
				{
					return;
				}
				_targetThreat = value;
				PropertySet(this);
			}
		}

		public CheckThreat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
