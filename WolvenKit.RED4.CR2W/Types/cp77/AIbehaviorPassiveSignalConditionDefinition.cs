using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPassiveSignalConditionDefinition : AIbehaviorPassiveConditionDefinition
	{
		private CName _tag;
		private CBool _deactivateSignal;

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("deactivateSignal")] 
		public CBool DeactivateSignal
		{
			get
			{
				if (_deactivateSignal == null)
				{
					_deactivateSignal = (CBool) CR2WTypeManager.Create("Bool", "deactivateSignal", cr2w, this);
				}
				return _deactivateSignal;
			}
			set
			{
				if (_deactivateSignal == value)
				{
					return;
				}
				_deactivateSignal = value;
				PropertySet(this);
			}
		}

		public AIbehaviorPassiveSignalConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
