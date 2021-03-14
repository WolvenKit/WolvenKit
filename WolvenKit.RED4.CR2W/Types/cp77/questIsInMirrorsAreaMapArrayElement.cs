using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questIsInMirrorsAreaMapArrayElement : CVariable
	{
		private NodeRef _objectRef;
		private CBool _isInMirrorsArea;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "objectRef", cr2w, this);
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
		[RED("isInMirrorsArea")] 
		public CBool IsInMirrorsArea
		{
			get
			{
				if (_isInMirrorsArea == null)
				{
					_isInMirrorsArea = (CBool) CR2WTypeManager.Create("Bool", "isInMirrorsArea", cr2w, this);
				}
				return _isInMirrorsArea;
			}
			set
			{
				if (_isInMirrorsArea == value)
				{
					return;
				}
				_isInMirrorsArea = value;
				PropertySet(this);
			}
		}

		public questIsInMirrorsAreaMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
