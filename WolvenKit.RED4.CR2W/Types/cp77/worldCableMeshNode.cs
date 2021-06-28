using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCableMeshNode : worldBendedMeshNode
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

		public worldCableMeshNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
