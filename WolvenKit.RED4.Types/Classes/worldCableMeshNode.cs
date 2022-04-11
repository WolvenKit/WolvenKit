using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCableMeshNode : worldBendedMeshNode
	{
		[Ordinal(13)] 
		[RED("destructionHashes", 2)] 
		public CArrayFixedSize<CUInt64> DestructionHashes
		{
			get => GetPropertyValue<CArrayFixedSize<CUInt64>>();
			set => SetPropertyValue<CArrayFixedSize<CUInt64>>(value);
		}

		[Ordinal(14)] 
		[RED("cableLength")] 
		public CFloat CableLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("cableRadius")] 
		public CFloat CableRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldCableMeshNode()
		{
			DestructionHashes = new(2);
		}
	}
}
