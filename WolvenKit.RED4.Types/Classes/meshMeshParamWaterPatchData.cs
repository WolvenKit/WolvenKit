using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamWaterPatchData : meshMeshParameter
	{
		private CBool _animLoop;
		private CFloat _animLength;
		private CStatic<CStatic<CFloat>> _nodes;

		[Ordinal(0)] 
		[RED("animLoop")] 
		public CBool AnimLoop
		{
			get => GetProperty(ref _animLoop);
			set => SetProperty(ref _animLoop, value);
		}

		[Ordinal(1)] 
		[RED("animLength")] 
		public CFloat AnimLength
		{
			get => GetProperty(ref _animLength);
			set => SetProperty(ref _animLength, value);
		}

		[Ordinal(2)] 
		[RED("nodes", 4096, 16)] 
		public CStatic<CStatic<CFloat>> Nodes
		{
			get => GetProperty(ref _nodes);
			set => SetProperty(ref _nodes, value);
		}
	}
}
