using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Katana : gameweaponObject
	{
		private CName _bentBulletTemplateName;
		private CName _bulletBendingReferenceSlotName;
		private CHandle<entIComponent> _colliderComponent;
		private CHandle<entSlotComponent> _slotComponent;

		[Ordinal(57)] 
		[RED("bentBulletTemplateName")] 
		public CName BentBulletTemplateName
		{
			get
			{
				if (_bentBulletTemplateName == null)
				{
					_bentBulletTemplateName = (CName) CR2WTypeManager.Create("CName", "bentBulletTemplateName", cr2w, this);
				}
				return _bentBulletTemplateName;
			}
			set
			{
				if (_bentBulletTemplateName == value)
				{
					return;
				}
				_bentBulletTemplateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("bulletBendingReferenceSlotName")] 
		public CName BulletBendingReferenceSlotName
		{
			get
			{
				if (_bulletBendingReferenceSlotName == null)
				{
					_bulletBendingReferenceSlotName = (CName) CR2WTypeManager.Create("CName", "bulletBendingReferenceSlotName", cr2w, this);
				}
				return _bulletBendingReferenceSlotName;
			}
			set
			{
				if (_bulletBendingReferenceSlotName == value)
				{
					return;
				}
				_bulletBendingReferenceSlotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("colliderComponent")] 
		public CHandle<entIComponent> ColliderComponent
		{
			get
			{
				if (_colliderComponent == null)
				{
					_colliderComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "colliderComponent", cr2w, this);
				}
				return _colliderComponent;
			}
			set
			{
				if (_colliderComponent == value)
				{
					return;
				}
				_colliderComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get
			{
				if (_slotComponent == null)
				{
					_slotComponent = (CHandle<entSlotComponent>) CR2WTypeManager.Create("handle:entSlotComponent", "slotComponent", cr2w, this);
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

		public Katana(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
