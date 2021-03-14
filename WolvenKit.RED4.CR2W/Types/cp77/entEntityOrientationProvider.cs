using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEntityOrientationProvider : entIOrientationProvider
	{
		private wCHandle<entSlotComponent> _slotComponent;
		private CInt32 _slotId;
		private wCHandle<entEntity> _entity;
		private Quaternion _orientationEntitySpace;

		[Ordinal(0)] 
		[RED("slotComponent")] 
		public wCHandle<entSlotComponent> SlotComponent
		{
			get
			{
				if (_slotComponent == null)
				{
					_slotComponent = (wCHandle<entSlotComponent>) CR2WTypeManager.Create("whandle:entSlotComponent", "slotComponent", cr2w, this);
				}
				return _slotComponent;
			}
			set
			{
				if (_slotComponent == value)
				{
					return;
				}
				_slotComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotId")] 
		public CInt32 SlotId
		{
			get
			{
				if (_slotId == null)
				{
					_slotId = (CInt32) CR2WTypeManager.Create("Int32", "slotId", cr2w, this);
				}
				return _slotId;
			}
			set
			{
				if (_slotId == value)
				{
					return;
				}
				_slotId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("orientationEntitySpace")] 
		public Quaternion OrientationEntitySpace
		{
			get
			{
				if (_orientationEntitySpace == null)
				{
					_orientationEntitySpace = (Quaternion) CR2WTypeManager.Create("Quaternion", "orientationEntitySpace", cr2w, this);
				}
				return _orientationEntitySpace;
			}
			set
			{
				if (_orientationEntitySpace == value)
				{
					return;
				}
				_orientationEntitySpace = value;
				PropertySet(this);
			}
		}

		public entEntityOrientationProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
