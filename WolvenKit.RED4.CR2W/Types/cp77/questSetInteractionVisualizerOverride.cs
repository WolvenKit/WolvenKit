using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetInteractionVisualizerOverride : questIInteractiveObjectManagerNodeType
	{
		private NodeRef _objectRef;
		private CBool _applyOverride;
		private CBool _removeAfterSingleUse;

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
		[RED("applyOverride")] 
		public CBool ApplyOverride
		{
			get
			{
				if (_applyOverride == null)
				{
					_applyOverride = (CBool) CR2WTypeManager.Create("Bool", "applyOverride", cr2w, this);
				}
				return _applyOverride;
			}
			set
			{
				if (_applyOverride == value)
				{
					return;
				}
				_applyOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("removeAfterSingleUse")] 
		public CBool RemoveAfterSingleUse
		{
			get
			{
				if (_removeAfterSingleUse == null)
				{
					_removeAfterSingleUse = (CBool) CR2WTypeManager.Create("Bool", "removeAfterSingleUse", cr2w, this);
				}
				return _removeAfterSingleUse;
			}
			set
			{
				if (_removeAfterSingleUse == value)
				{
					return;
				}
				_removeAfterSingleUse = value;
				PropertySet(this);
			}
		}

		public questSetInteractionVisualizerOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
