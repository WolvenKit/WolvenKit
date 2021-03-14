using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetAttachment_ToActor : questIEntityManagerSetAttachment_NodeSubType
	{
		private NodeRef _attachmentRef;
		private gameEntityReference _objectRef;
		private CBool _isPlayer;
		private CName _slot;
		private CEnum<questAttachmentOffsetMode> _offsetMode;
		private Vector3 _customOffsetPos;
		private Quaternion _customOffsetRot;

		[Ordinal(0)] 
		[RED("attachmentRef")] 
		public NodeRef AttachmentRef
		{
			get
			{
				if (_attachmentRef == null)
				{
					_attachmentRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "attachmentRef", cr2w, this);
				}
				return _attachmentRef;
			}
			set
			{
				if (_attachmentRef == value)
				{
					return;
				}
				_attachmentRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("offsetMode")] 
		public CEnum<questAttachmentOffsetMode> OffsetMode
		{
			get
			{
				if (_offsetMode == null)
				{
					_offsetMode = (CEnum<questAttachmentOffsetMode>) CR2WTypeManager.Create("questAttachmentOffsetMode", "offsetMode", cr2w, this);
				}
				return _offsetMode;
			}
			set
			{
				if (_offsetMode == value)
				{
					return;
				}
				_offsetMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get
			{
				if (_customOffsetPos == null)
				{
					_customOffsetPos = (Vector3) CR2WTypeManager.Create("Vector3", "customOffsetPos", cr2w, this);
				}
				return _customOffsetPos;
			}
			set
			{
				if (_customOffsetPos == value)
				{
					return;
				}
				_customOffsetPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get
			{
				if (_customOffsetRot == null)
				{
					_customOffsetRot = (Quaternion) CR2WTypeManager.Create("Quaternion", "customOffsetRot", cr2w, this);
				}
				return _customOffsetRot;
			}
			set
			{
				if (_customOffsetRot == value)
				{
					return;
				}
				_customOffsetRot = value;
				PropertySet(this);
			}
		}

		public questEntityManagerSetAttachment_ToActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
