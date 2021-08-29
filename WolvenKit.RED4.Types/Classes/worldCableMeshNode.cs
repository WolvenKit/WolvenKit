using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCableMeshNode : worldBendedMeshNode
	{
		private CArrayFixedSize<CUInt64> _destructionHashes;
		private CFloat _cableLength;
		private CFloat _cableRadius;

		[Ordinal(13)] 
		[RED("destructionHashes", 2)] 
		public CArrayFixedSize<CUInt64> DestructionHashes
		{
			get => GetProperty(ref _destructionHashes);
			set => SetProperty(ref _destructionHashes, value);
		}

		[Ordinal(14)] 
		[RED("cableLength")] 
		public CFloat CableLength
		{
			get => GetProperty(ref _cableLength);
			set => SetProperty(ref _cableLength, value);
		}

		[Ordinal(15)] 
		[RED("cableRadius")] 
		public CFloat CableRadius
		{
			get => GetProperty(ref _cableRadius);
			set => SetProperty(ref _cableRadius, value);
		}
	}
}
