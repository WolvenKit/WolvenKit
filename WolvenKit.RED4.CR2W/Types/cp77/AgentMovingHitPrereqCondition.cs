using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AgentMovingHitPrereqCondition : BaseHitPrereqCondition
	{
		private CBool _isMoving;
		private CName _object;

		[Ordinal(1)] 
		[RED("isMoving")] 
		public CBool IsMoving
		{
			get
			{
				if (_isMoving == null)
				{
					_isMoving = (CBool) CR2WTypeManager.Create("Bool", "isMoving", cr2w, this);
				}
				return _isMoving;
			}
			set
			{
				if (_isMoving == value)
				{
					return;
				}
				_isMoving = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("object")] 
		public CName Object
		{
			get
			{
				if (_object == null)
				{
					_object = (CName) CR2WTypeManager.Create("CName", "object", cr2w, this);
				}
				return _object;
			}
			set
			{
				if (_object == value)
				{
					return;
				}
				_object = value;
				PropertySet(this);
			}
		}

		public AgentMovingHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
