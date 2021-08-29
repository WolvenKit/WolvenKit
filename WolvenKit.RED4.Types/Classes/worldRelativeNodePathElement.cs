using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRelativeNodePathElement : RedBaseClass
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
	}
}
