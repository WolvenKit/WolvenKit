using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRelativeNodePathElement : CVariable
	{
		private CString _prefab;
		private CUInt64 _nodeID;

		[Ordinal(0)] 
		[RED("prefab")] 
		public CString Prefab
		{
			get
			{
				if (_prefab == null)
				{
					_prefab = (CString) CR2WTypeManager.Create("String", "prefab", cr2w, this);
				}
				return _prefab;
			}
			set
			{
				if (_prefab == value)
				{
					return;
				}
				_prefab = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("nodeID")] 
		public CUInt64 NodeID
		{
			get
			{
				if (_nodeID == null)
				{
					_nodeID = (CUInt64) CR2WTypeManager.Create("Uint64", "nodeID", cr2w, this);
				}
				return _nodeID;
			}
			set
			{
				if (_nodeID == value)
				{
					return;
				}
				_nodeID = value;
				PropertySet(this);
			}
		}

		public worldRelativeNodePathElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
