using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questNodeCollisionMapArrayElement : CVariable
	{
		private NodeRef _objectRef;
		private CArray<questComponentCollisionMapArrayElement> _componentsCollisionMapArray;

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
		[RED("componentsCollisionMapArray")] 
		public CArray<questComponentCollisionMapArrayElement> ComponentsCollisionMapArray
		{
			get
			{
				if (_componentsCollisionMapArray == null)
				{
					_componentsCollisionMapArray = (CArray<questComponentCollisionMapArrayElement>) CR2WTypeManager.Create("array:questComponentCollisionMapArrayElement", "componentsCollisionMapArray", cr2w, this);
				}
				return _componentsCollisionMapArray;
			}
			set
			{
				if (_componentsCollisionMapArray == value)
				{
					return;
				}
				_componentsCollisionMapArray = value;
				PropertySet(this);
			}
		}

		public questNodeCollisionMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
