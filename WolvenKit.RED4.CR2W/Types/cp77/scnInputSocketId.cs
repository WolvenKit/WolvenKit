using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInputSocketId : CVariable
	{
		private scnNodeId _nodeId;
		private scnInputSocketStamp _isockStamp;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get => GetProperty(ref _nodeId);
			set => SetProperty(ref _nodeId, value);
		}

		[Ordinal(1)] 
		[RED("isockStamp")] 
		public scnInputSocketStamp IsockStamp
		{
			get => GetProperty(ref _isockStamp);
			set => SetProperty(ref _isockStamp, value);
		}

		public scnInputSocketId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
