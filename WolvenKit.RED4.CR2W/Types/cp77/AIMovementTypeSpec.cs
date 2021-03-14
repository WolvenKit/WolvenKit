using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMovementTypeSpec : CVariable
	{
		private CBool _useNPCMovementParams;
		private CEnum<moveMovementType> _movementType;

		[Ordinal(0)] 
		[RED("useNPCMovementParams")] 
		public CBool UseNPCMovementParams
		{
			get
			{
				if (_useNPCMovementParams == null)
				{
					_useNPCMovementParams = (CBool) CR2WTypeManager.Create("Bool", "useNPCMovementParams", cr2w, this);
				}
				return _useNPCMovementParams;
			}
			set
			{
				if (_useNPCMovementParams == value)
				{
					return;
				}
				_useNPCMovementParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (CEnum<moveMovementType>) CR2WTypeManager.Create("moveMovementType", "movementType", cr2w, this);
				}
				return _movementType;
			}
			set
			{
				if (_movementType == value)
				{
					return;
				}
				_movementType = value;
				PropertySet(this);
			}
		}

		public AIMovementTypeSpec(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
