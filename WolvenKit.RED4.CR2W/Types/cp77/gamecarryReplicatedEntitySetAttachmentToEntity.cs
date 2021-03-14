using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamecarryReplicatedEntitySetAttachmentToEntity : netEntityAttachmentInterface
	{
		private wCHandle<entEntity> _entity;
		private CName _slot;
		private Transform _localTransform;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("slot")] 
		public CName Slot
		{
			get
			{
				if (_slot == null)
				{
					_slot = (CName) CR2WTypeManager.Create("CName", "slot", cr2w, this);
				}
				return _slot;
			}
			set
			{
				if (_slot == value)
				{
					return;
				}
				_slot = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("localTransform")] 
		public Transform LocalTransform
		{
			get
			{
				if (_localTransform == null)
				{
					_localTransform = (Transform) CR2WTypeManager.Create("Transform", "localTransform", cr2w, this);
				}
				return _localTransform;
			}
			set
			{
				if (_localTransform == value)
				{
					return;
				}
				_localTransform = value;
				PropertySet(this);
			}
		}

		public gamecarryReplicatedEntitySetAttachmentToEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
