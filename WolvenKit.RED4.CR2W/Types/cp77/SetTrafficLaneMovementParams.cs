using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetTrafficLaneMovementParams : AIbehaviortaskScript
	{
		private CString _movementType;
		private CEnum<gameFearStage> _fearStage;

		[Ordinal(0)] 
		[RED("movementType")] 
		public CString MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (CString) CR2WTypeManager.Create("String", "movementType", cr2w, this);
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

		[Ordinal(1)] 
		[RED("fearStage")] 
		public CEnum<gameFearStage> FearStage
		{
			get
			{
				if (_fearStage == null)
				{
					_fearStage = (CEnum<gameFearStage>) CR2WTypeManager.Create("gameFearStage", "fearStage", cr2w, this);
				}
				return _fearStage;
			}
			set
			{
				if (_fearStage == value)
				{
					return;
				}
				_fearStage = value;
				PropertySet(this);
			}
		}

		public SetTrafficLaneMovementParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
