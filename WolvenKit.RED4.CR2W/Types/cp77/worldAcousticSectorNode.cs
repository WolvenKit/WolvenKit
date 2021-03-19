using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAcousticSectorNode : worldNode
	{
		private raRef<worldAcousticDataResource> _data;
		private CUInt32 _inSectorCoordsX;
		private CUInt32 _inSectorCoordsY;
		private CUInt32 _inSectorCoordsZ;
		private CUInt32 _generatorId;
		private CUInt8 _edgeMask;

		[Ordinal(4)] 
		[RED("data")] 
		public raRef<worldAcousticDataResource> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(5)] 
		[RED("inSectorCoordsX")] 
		public CUInt32 InSectorCoordsX
		{
			get => GetProperty(ref _inSectorCoordsX);
			set => SetProperty(ref _inSectorCoordsX, value);
		}

		[Ordinal(6)] 
		[RED("inSectorCoordsY")] 
		public CUInt32 InSectorCoordsY
		{
			get => GetProperty(ref _inSectorCoordsY);
			set => SetProperty(ref _inSectorCoordsY, value);
		}

		[Ordinal(7)] 
		[RED("inSectorCoordsZ")] 
		public CUInt32 InSectorCoordsZ
		{
			get => GetProperty(ref _inSectorCoordsZ);
			set => SetProperty(ref _inSectorCoordsZ, value);
		}

		[Ordinal(8)] 
		[RED("generatorId")] 
		public CUInt32 GeneratorId
		{
			get => GetProperty(ref _generatorId);
			set => SetProperty(ref _generatorId, value);
		}

		[Ordinal(9)] 
		[RED("edgeMask")] 
		public CUInt8 EdgeMask
		{
			get => GetProperty(ref _edgeMask);
			set => SetProperty(ref _edgeMask, value);
		}

		public worldAcousticSectorNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
