using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetFocusClueState_NodeType : questIVisionModeNodeType
	{
		private gameEntityReference _objectRef;
		private CInt32 _clueId;
		private CBool _clueState;

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
		[RED("clueId")] 
		public CInt32 ClueId
		{
			get
			{
				if (_clueId == null)
				{
					_clueId = (CInt32) CR2WTypeManager.Create("Int32", "clueId", cr2w, this);
				}
				return _clueId;
			}
			set
			{
				if (_clueId == value)
				{
					return;
				}
				_clueId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("clueState")] 
		public CBool ClueState
		{
			get
			{
				if (_clueState == null)
				{
					_clueState = (CBool) CR2WTypeManager.Create("Bool", "clueState", cr2w, this);
				}
				return _clueState;
			}
			set
			{
				if (_clueState == value)
				{
					return;
				}
				_clueState = value;
				PropertySet(this);
			}
		}

		public questSetFocusClueState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
