using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CGIDataResource : resStreamedResource
	{
		private serializationDeferredDataBuffer _data;
		private CUInt64 _sectorHash;

		[Ordinal(1)] 
		[RED("data")] 
		public serializationDeferredDataBuffer Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(2)] 
		[RED("sectorHash")] 
		public CUInt64 SectorHash
		{
			get => GetProperty(ref _sectorHash);
			set => SetProperty(ref _sectorHash, value);
		}

		public CGIDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
