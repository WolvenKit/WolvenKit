using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetLootInteractionAccess_NodeType : questIItemManagerNodeType
	{
		private gameEntityReference _objectRef;
		private CBool _accessible;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("accessible")] 
		public CBool Accessible
		{
			get
			{
				if (_accessible == null)
				{
					_accessible = (CBool) CR2WTypeManager.Create("Bool", "accessible", cr2w, this);
				}
				return _accessible;
			}
			set
			{
				if (_accessible == value)
				{
					return;
				}
				_accessible = value;
				PropertySet(this);
			}
		}

		public questSetLootInteractionAccess_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
