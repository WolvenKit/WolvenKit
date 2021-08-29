using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnAndNode : scnSceneGraphNode
	{
		private CUInt32 _numInSockets;

		[Ordinal(3)] 
		[RED("numInSockets")] 
		public CUInt32 NumInSockets
		{
			get => GetProperty(ref _numInSockets);
			set => SetProperty(ref _numInSockets, value);
		}
	}
}
