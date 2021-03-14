using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorBehaviorIncludedDebuggerCommandEntry : CVariable
	{
		private CGUID _nodeId;
		private CString _includedBehaviorResourcePath;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public CGUID NodeId
		{
			get
			{
				if (_nodeId == null)
				{
					_nodeId = (CGUID) CR2WTypeManager.Create("CGUID", "nodeId", cr2w, this);
				}
				return _nodeId;
			}
			set
			{
				if (_nodeId == value)
				{
					return;
				}
				_nodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("includedBehaviorResourcePath")] 
		public CString IncludedBehaviorResourcePath
		{
			get
			{
				if (_includedBehaviorResourcePath == null)
				{
					_includedBehaviorResourcePath = (CString) CR2WTypeManager.Create("String", "includedBehaviorResourcePath", cr2w, this);
				}
				return _includedBehaviorResourcePath;
			}
			set
			{
				if (_includedBehaviorResourcePath == value)
				{
					return;
				}
				_includedBehaviorResourcePath = value;
				PropertySet(this);
			}
		}

		public AIbehaviorBehaviorIncludedDebuggerCommandEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
