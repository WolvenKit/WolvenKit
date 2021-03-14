using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAndNode : scnSceneGraphNode
	{
		private CUInt32 _numInSockets;

		[Ordinal(3)] 
		[RED("numInSockets")] 
		public CUInt32 NumInSockets
		{
			get
			{
				if (_numInSockets == null)
				{
					_numInSockets = (CUInt32) CR2WTypeManager.Create("Uint32", "numInSockets", cr2w, this);
				}
				return _numInSockets;
			}
			set
			{
				if (_numInSockets == value)
				{
					return;
				}
				_numInSockets = value;
				PropertySet(this);
			}
		}

		public scnAndNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
