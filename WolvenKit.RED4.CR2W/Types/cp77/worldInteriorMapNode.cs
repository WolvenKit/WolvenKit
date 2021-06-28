using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldInteriorMapNode : worldNode
	{
		private CUInt32 _version;
		private CUInt64 _coords;
		private serializationDeferredDataBuffer _buffer;

		[Ordinal(4)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(5)] 
		[RED("coords")] 
		public CUInt64 Coords
		{
			get => GetProperty(ref _coords);
			set => SetProperty(ref _coords, value);
		}

		[Ordinal(6)] 
		[RED("buffer")] 
		public serializationDeferredDataBuffer Buffer
		{
			get => GetProperty(ref _buffer);
			set => SetProperty(ref _buffer, value);
		}

		public worldInteriorMapNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
