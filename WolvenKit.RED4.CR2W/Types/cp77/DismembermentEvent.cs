using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismembermentEvent : redEvent
	{
		private CEnum<gameDismBodyPart> _bodyPart;
		private CEnum<gameDismWoundType> _woundType;
		private CFloat _strength;
		private CBool _isCritical;
		private CString _debrisPath;
		private CFloat _debrisStrength;

		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CEnum<gameDismBodyPart> BodyPart
		{
			get
			{
				if (_bodyPart == null)
				{
					_bodyPart = (CEnum<gameDismBodyPart>) CR2WTypeManager.Create("gameDismBodyPart", "bodyPart", cr2w, this);
				}
				return _bodyPart;
			}
			set
			{
				if (_bodyPart == value)
				{
					return;
				}
				_bodyPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("woundType")] 
		public CEnum<gameDismWoundType> WoundType
		{
			get
			{
				if (_woundType == null)
				{
					_woundType = (CEnum<gameDismWoundType>) CR2WTypeManager.Create("gameDismWoundType", "woundType", cr2w, this);
				}
				return _woundType;
			}
			set
			{
				if (_woundType == value)
				{
					return;
				}
				_woundType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get
			{
				if (_strength == null)
				{
					_strength = (CFloat) CR2WTypeManager.Create("Float", "strength", cr2w, this);
				}
				return _strength;
			}
			set
			{
				if (_strength == value)
				{
					return;
				}
				_strength = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isCritical")] 
		public CBool IsCritical
		{
			get
			{
				if (_isCritical == null)
				{
					_isCritical = (CBool) CR2WTypeManager.Create("Bool", "isCritical", cr2w, this);
				}
				return _isCritical;
			}
			set
			{
				if (_isCritical == value)
				{
					return;
				}
				_isCritical = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("debrisPath")] 
		public CString DebrisPath
		{
			get
			{
				if (_debrisPath == null)
				{
					_debrisPath = (CString) CR2WTypeManager.Create("String", "debrisPath", cr2w, this);
				}
				return _debrisPath;
			}
			set
			{
				if (_debrisPath == value)
				{
					return;
				}
				_debrisPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("debrisStrength")] 
		public CFloat DebrisStrength
		{
			get
			{
				if (_debrisStrength == null)
				{
					_debrisStrength = (CFloat) CR2WTypeManager.Create("Float", "debrisStrength", cr2w, this);
				}
				return _debrisStrength;
			}
			set
			{
				if (_debrisStrength == value)
				{
					return;
				}
				_debrisStrength = value;
				PropertySet(this);
			}
		}

		public DismembermentEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
