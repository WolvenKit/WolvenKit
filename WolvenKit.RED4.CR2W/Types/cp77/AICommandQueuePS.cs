using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICommandQueuePS : gameComponentPS
	{
		private CArray<CHandle<AIArgumentInstancePS>> _behaviorArgumentList;
		private CHandle<AIRole> _aiRole;

		[Ordinal(0)] 
		[RED("behaviorArgumentList")] 
		public CArray<CHandle<AIArgumentInstancePS>> BehaviorArgumentList
		{
			get
			{
				if (_behaviorArgumentList == null)
				{
					_behaviorArgumentList = (CArray<CHandle<AIArgumentInstancePS>>) CR2WTypeManager.Create("array:handle:AIArgumentInstancePS", "behaviorArgumentList", cr2w, this);
				}
				return _behaviorArgumentList;
			}
			set
			{
				if (_behaviorArgumentList == value)
				{
					return;
				}
				_behaviorArgumentList = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("aiRole")] 
		public CHandle<AIRole> AiRole
		{
			get
			{
				if (_aiRole == null)
				{
					_aiRole = (CHandle<AIRole>) CR2WTypeManager.Create("handle:AIRole", "aiRole", cr2w, this);
				}
				return _aiRole;
			}
			set
			{
				if (_aiRole == value)
				{
					return;
				}
				_aiRole = value;
				PropertySet(this);
			}
		}

		public AICommandQueuePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
