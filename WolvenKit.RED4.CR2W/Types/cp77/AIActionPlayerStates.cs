using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionPlayerStates : CVariable
	{
		private CArray<CEnum<gamePSMLocomotionStates>> _locomotionStates;
		private CArray<CEnum<gamePSMUpperBodyStates>> _upperBodyStates;
		private CArray<CEnum<gamePSMMelee>> _meleeStates;
		private CArray<CEnum<gamePSMZones>> _zoneStates;
		private CArray<CEnum<gamePSMBodyCarrying>> _bodyCarryStates;

		[Ordinal(0)] 
		[RED("locomotionStates")] 
		public CArray<CEnum<gamePSMLocomotionStates>> LocomotionStates
		{
			get
			{
				if (_locomotionStates == null)
				{
					_locomotionStates = (CArray<CEnum<gamePSMLocomotionStates>>) CR2WTypeManager.Create("array:gamePSMLocomotionStates", "locomotionStates", cr2w, this);
				}
				return _locomotionStates;
			}
			set
			{
				if (_locomotionStates == value)
				{
					return;
				}
				_locomotionStates = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("upperBodyStates")] 
		public CArray<CEnum<gamePSMUpperBodyStates>> UpperBodyStates
		{
			get
			{
				if (_upperBodyStates == null)
				{
					_upperBodyStates = (CArray<CEnum<gamePSMUpperBodyStates>>) CR2WTypeManager.Create("array:gamePSMUpperBodyStates", "upperBodyStates", cr2w, this);
				}
				return _upperBodyStates;
			}
			set
			{
				if (_upperBodyStates == value)
				{
					return;
				}
				_upperBodyStates = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("meleeStates")] 
		public CArray<CEnum<gamePSMMelee>> MeleeStates
		{
			get
			{
				if (_meleeStates == null)
				{
					_meleeStates = (CArray<CEnum<gamePSMMelee>>) CR2WTypeManager.Create("array:gamePSMMelee", "meleeStates", cr2w, this);
				}
				return _meleeStates;
			}
			set
			{
				if (_meleeStates == value)
				{
					return;
				}
				_meleeStates = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("zoneStates")] 
		public CArray<CEnum<gamePSMZones>> ZoneStates
		{
			get
			{
				if (_zoneStates == null)
				{
					_zoneStates = (CArray<CEnum<gamePSMZones>>) CR2WTypeManager.Create("array:gamePSMZones", "zoneStates", cr2w, this);
				}
				return _zoneStates;
			}
			set
			{
				if (_zoneStates == value)
				{
					return;
				}
				_zoneStates = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bodyCarryStates")] 
		public CArray<CEnum<gamePSMBodyCarrying>> BodyCarryStates
		{
			get
			{
				if (_bodyCarryStates == null)
				{
					_bodyCarryStates = (CArray<CEnum<gamePSMBodyCarrying>>) CR2WTypeManager.Create("array:gamePSMBodyCarrying", "bodyCarryStates", cr2w, this);
				}
				return _bodyCarryStates;
			}
			set
			{
				if (_bodyCarryStates == value)
				{
					return;
				}
				_bodyCarryStates = value;
				PropertySet(this);
			}
		}

		public AIActionPlayerStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
