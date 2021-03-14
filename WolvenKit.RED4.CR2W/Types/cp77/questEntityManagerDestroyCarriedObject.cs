using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerDestroyCarriedObject : questIEntityManagerSetAttachment_NodeSubType
	{
		private NodeRef _attachmentRef;
		private gameEntityReference _objectRef;
		private CBool _isPlayer;

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

		public questEntityManagerDestroyCarriedObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
