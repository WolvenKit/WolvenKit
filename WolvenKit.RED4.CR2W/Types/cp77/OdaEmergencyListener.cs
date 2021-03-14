using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OdaEmergencyListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<NPCPuppet> _owner;
		private CInt32 _healNumber;
		private CFloat _heal1HealthPercentage;
		private CFloat _heal2HealthPercentage;
		private CFloat _heal3HealthPercentage;
		private CFloat _heal4HealthPercentage;
		private CFloat _heal5HealthPercentage;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<NPCPuppet>) CR2WTypeManager.Create("whandle:NPCPuppet", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("healNumber")] 
		public CInt32 HealNumber
		{
			get
			{
				if (_healNumber == null)
				{
					_healNumber = (CInt32) CR2WTypeManager.Create("Int32", "healNumber", cr2w, this);
				}
				return _healNumber;
			}
			set
			{
				if (_healNumber == value)
				{
					return;
				}
				_healNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("heal1HealthPercentage")] 
		public CFloat Heal1HealthPercentage
		{
			get
			{
				if (_heal1HealthPercentage == null)
				{
					_heal1HealthPercentage = (CFloat) CR2WTypeManager.Create("Float", "heal1HealthPercentage", cr2w, this);
				}
				return _heal1HealthPercentage;
			}
			set
			{
				if (_heal1HealthPercentage == value)
				{
					return;
				}
				_heal1HealthPercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("heal2HealthPercentage")] 
		public CFloat Heal2HealthPercentage
		{
			get
			{
				if (_heal2HealthPercentage == null)
				{
					_heal2HealthPercentage = (CFloat) CR2WTypeManager.Create("Float", "heal2HealthPercentage", cr2w, this);
				}
				return _heal2HealthPercentage;
			}
			set
			{
				if (_heal2HealthPercentage == value)
				{
					return;
				}
				_heal2HealthPercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("heal3HealthPercentage")] 
		public CFloat Heal3HealthPercentage
		{
			get
			{
				if (_heal3HealthPercentage == null)
				{
					_heal3HealthPercentage = (CFloat) CR2WTypeManager.Create("Float", "heal3HealthPercentage", cr2w, this);
				}
				return _heal3HealthPercentage;
			}
			set
			{
				if (_heal3HealthPercentage == value)
				{
					return;
				}
				_heal3HealthPercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("heal4HealthPercentage")] 
		public CFloat Heal4HealthPercentage
		{
			get
			{
				if (_heal4HealthPercentage == null)
				{
					_heal4HealthPercentage = (CFloat) CR2WTypeManager.Create("Float", "heal4HealthPercentage", cr2w, this);
				}
				return _heal4HealthPercentage;
			}
			set
			{
				if (_heal4HealthPercentage == value)
				{
					return;
				}
				_heal4HealthPercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("heal5HealthPercentage")] 
		public CFloat Heal5HealthPercentage
		{
			get
			{
				if (_heal5HealthPercentage == null)
				{
					_heal5HealthPercentage = (CFloat) CR2WTypeManager.Create("Float", "heal5HealthPercentage", cr2w, this);
				}
				return _heal5HealthPercentage;
			}
			set
			{
				if (_heal5HealthPercentage == value)
				{
					return;
				}
				_heal5HealthPercentage = value;
				PropertySet(this);
			}
		}

		public OdaEmergencyListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
