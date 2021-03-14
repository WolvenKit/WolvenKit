using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLightListenerComponent : entIComponent
	{
		private NodeRef _intersectionRef;
		private CUInt32 _groupIdx;

		[Ordinal(3)] 
		[RED("intersectionRef")] 
		public NodeRef IntersectionRef
		{
			get
			{
				if (_intersectionRef == null)
				{
					_intersectionRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "intersectionRef", cr2w, this);
				}
				return _intersectionRef;
			}
			set
			{
				if (_intersectionRef == value)
				{
					return;
				}
				_intersectionRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("groupIdx")] 
		public CUInt32 GroupIdx
		{
			get
			{
				if (_groupIdx == null)
				{
					_groupIdx = (CUInt32) CR2WTypeManager.Create("Uint32", "groupIdx", cr2w, this);
				}
				return _groupIdx;
			}
			set
			{
				if (_groupIdx == value)
				{
					return;
				}
				_groupIdx = value;
				PropertySet(this);
			}
		}

		public worldTrafficLightListenerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
