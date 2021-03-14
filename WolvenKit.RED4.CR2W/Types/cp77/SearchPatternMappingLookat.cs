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

		[Ordinal(15)] 
		[RED("lookatTargetObject")] 
		public wCHandle<gameObject> LookatTargetObject
		{
			get
			{
				if (_lookatTargetObject == null)
				{
					_lookatTargetObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "lookatTargetObject", cr2w, this);
				}
				return _lookatTargetObject;
			}
			set
			{
				if (_lookatTargetObject == value)
				{
					return;
				}
				_lookatTargetObject = value;
				PropertySet(this);
			}
		}

		public SearchPatternMappingLookat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
