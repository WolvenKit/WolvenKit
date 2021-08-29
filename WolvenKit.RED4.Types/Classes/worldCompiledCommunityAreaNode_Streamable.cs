using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCompiledCommunityAreaNode_Streamable : worldCompiledCommunityAreaNode
	{
		private CFloat _streamingDistance;

		[Ordinal(6)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetProperty(ref _streamingDistance);
			set => SetProperty(ref _streamingDistance, value);
		}
	}
}
