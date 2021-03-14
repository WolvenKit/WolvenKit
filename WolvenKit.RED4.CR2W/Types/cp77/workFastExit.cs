using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workFastExit : workIEntry
	{
		private CName _animName;
		private CFloat _forcedBlendIn;
		private CEnum<moveMovementType> _movementType;

		[Ordinal(2)] 
		[RED("animName")] 
		public CName AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (CName) CR2WTypeManager.Create("CName", "animName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("forcedBlendIn")] 
		public CFloat ForcedBlendIn
		{
			get
			{
				if (_forcedBlendIn == null)
				{
					_forcedBlendIn = (CFloat) CR2WTypeManager.Create("Float", "forcedBlendIn", cr2w, this);
				}
				return _forcedBlendIn;
			}
			set
			{
				if (_forcedBlendIn == value)
				{
					return;
				}
				_forcedBlendIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		public workFastExit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
