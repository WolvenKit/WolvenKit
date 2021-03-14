using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsTargetObjectPlayer : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _targetObject;

		[Ordinal(0)] 
		[RED("targetObject")] 
		public CHandle<AIArgumentMapping> TargetObject
		{
			get
			{
				if (_targetObject == null)
				{
					_targetObject = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "targetObject", cr2w, this);
				}
				return _targetObject;
			}
			set
			{
				if (_targetObject == value)
				{
					return;
				}
				_targetObject = value;
				PropertySet(this);
			}
		}

		public IsTargetObjectPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
