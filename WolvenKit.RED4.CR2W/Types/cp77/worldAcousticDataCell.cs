using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAcousticDataCell : CVariable
	{
		private serializationDeferredDataBuffer _nodes;
		private CUInt32 _sectorId;

		[Ordinal(0)] 
		[RED("nodes")] 
		public serializationDeferredDataBuffer Nodes
		{
			get => GetProperty(ref _nodes);
			set => SetProperty(ref _nodes, value);
		}

		[Ordinal(1)] 
		[RED("sectorId")] 
		public CUInt32 SectorId
		{
			get => GetProperty(ref _sectorId);
			set => SetProperty(ref _sectorId, value);
		}

		public worldAcousticDataCell(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
