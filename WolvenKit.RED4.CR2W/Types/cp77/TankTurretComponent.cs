using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TankTurretComponent : gameScriptableComponent
	{
		private TweakDBID _attackRecord;
		private CName _slotComponentName1;
		private CName _slotName1;
		private CName _slotComponentName2;
		private CName _slotName2;
		private CHandle<entSlotComponent> _slotComponent1;
		private CHandle<entSlotComponent> _slotComponent2;

		[Ordinal(5)] 
		[RED("attackRecord")] 
		public TweakDBID AttackRecord
		{
			get
			{
				if (_attackRecord == null)
				{
					_attackRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attackRecord", cr2w, this);
				}
				return _attackRecord;
			}
			set
			{
				if (_attackRecord == value)
				{
					return;
				}
				_attackRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("slotComponentName1")] 
		public CName SlotComponentName1
		{
			get
			{
				if (_slotComponentName1 == null)
				{
					_slotComponentName1 = (CName) CR2WTypeManager.Create("CName", "slotComponentName1", cr2w, this);
				}
				return _slotComponentName1;
			}
			set
			{
				if (_slotComponentName1 == value)
				{
					return;
				}
				_slotComponentName1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("slotName1")] 
		public CName SlotName1
		{
			get
			{
				if (_slotName1 == null)
				{
					_slotName1 = (CName) CR2WTypeManager.Create("CName", "slotName1", cr2w, this);
				}
				return _slotName1;
			}
			set
			{
				if (_slotName1 == value)
				{
					return;
				}
				_slotName1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("slotComponentName2")] 
		public CName SlotComponentName2
		{
			get
			{
				if (_slotComponentName2 == null)
				{
					_slotComponentName2 = (CName) CR2WTypeManager.Create("CName", "slotComponentName2", cr2w, this);
				}
				return _slotComponentName2;
			}
			set
			{
				if (_slotComponentName2 == value)
				{
					return;
				}
				_slotComponentName2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("slotName2")] 
		public CName SlotName2
		{
			get
			{
				if (_slotName2 == null)
				{
					_slotName2 = (CName) CR2WTypeManager.Create("CName", "slotName2", cr2w, this);
				}
				return _slotName2;
			}
			set
			{
				if (_slotName2 == value)
				{
					return;
				}
				_slotName2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("slotComponent1")] 
		public CHandle<entSlotComponent> SlotComponent1
		{
			get
			{
				if (_slotComponent1 == null)
				{
					_slotComponent1 = (CHandle<entSlotComponent>) CR2WTypeManager.Create("handle:entSlotComponent", "slotComponent1", cr2w, this);
				}
				return _slotComponent1;
			}
			set
			{
				if (_slotComponent1 == value)
				{
					return;
				}
				_slotComponent1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("slotComponent2")] 
		public CHandle<entSlotComponent> SlotComponent2
		{
			get
			{
				if (_slotComponent2 == null)
				{
					_slotComponent2 = (CHandle<entSlotComponent>) CR2WTypeManager.Create("handle:entSlotComponent", "slotComponent2", cr2w, this);
				}
				return _slotComponent2;
			}
			set
			{
				if (_slotComponent2 == value)
				{
					return;
				}
				_slotComponent2 = value;
				PropertySet(this);
			}
		}

		public TankTurretComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
