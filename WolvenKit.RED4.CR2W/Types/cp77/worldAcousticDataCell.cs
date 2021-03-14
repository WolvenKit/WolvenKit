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
			get
			{
				if (_nodes == null)
				{
					_nodes = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "nodes", cr2w, this);
				}
				return _nodes;
			}
			set
			{
				if (_nodes == value)
				{
					return;
				}
				_nodes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sectorId")] 
		public CUInt32 SectorId
		{
			get
			{
				if (_sectorId == null)
				{
					_sectorId = (CUInt32) CR2WTypeManager.Create("Uint32", "sectorId", cr2w, this);
				}
				return _sectorId;
			}
			set
			{
				if (_sectorId == value)
				{
					return;
				}
				_sectorId = value;
				PropertySet(this);
			}
		}

		public worldAcousticDataCell(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
