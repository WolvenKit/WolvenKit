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
			get => GetProperty(ref _prefab);
			set => SetProperty(ref _prefab, value);
		}

		[Ordinal(1)] 
		[RED("nodeID")] 
		public CUInt64 NodeID
		{
			get => GetProperty(ref _nodeID);
			set => SetProperty(ref _nodeID, value);
		}

		public worldRelativeNodePathElement(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
