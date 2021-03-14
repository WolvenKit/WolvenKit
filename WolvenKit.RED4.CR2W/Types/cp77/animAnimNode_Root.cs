using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Root : animAnimNode_Container
	{
		private animPoseLink _outputNode;

		[Ordinal(12)] 
		[RED("outputNode")] 
		public animPoseLink OutputNode
		{
			get
			{
				if (_outputNode == null)
				{
					_outputNode = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "outputNode", cr2w, this);
				}
				return _outputNode;
			}
			set
			{
				if (_outputNode == value)
				{
					return;
				}
				_outputNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_Root(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
