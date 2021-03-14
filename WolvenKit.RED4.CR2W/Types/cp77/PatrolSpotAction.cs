using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PatrolSpotAction : TweakAIActionSmartComposite
	{
		private CHandle<AIArgumentMapping> _patrolAction;

		[Ordinal(38)] 
		[RED("patrolAction")] 
		public CHandle<AIArgumentMapping> PatrolAction
		{
			get
			{
				if (_patrolAction == null)
				{
					_patrolAction = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "patrolAction", cr2w, this);
				}
				return _patrolAction;
			}
			set
			{
				if (_patrolAction == value)
				{
					return;
				}
				_patrolAction = value;
				PropertySet(this);
			}
		}

		public PatrolSpotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
