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
			get
			{
				if (_data == null)
				{
					_data = (raRef<worldAcousticDataResource>) CR2WTypeManager.Create("raRef:worldAcousticDataResource", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("inSectorCoordsX")] 
		public CUInt32 InSectorCoordsX
		{
			get
			{
				if (_inSectorCoordsX == null)
				{
					_inSectorCoordsX = (CUInt32) CR2WTypeManager.Create("Uint32", "inSectorCoordsX", cr2w, this);
				}
				return _inSectorCoordsX;
			}
			set
			{
				if (_inSectorCoordsX == value)
				{
					return;
				}
				_inSectorCoordsX = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("inSectorCoordsY")] 
		public CUInt32 InSectorCoordsY
		{
			get
			{
				if (_inSectorCoordsY == null)
				{
					_inSectorCoordsY = (CUInt32) CR2WTypeManager.Create("Uint32", "inSectorCoordsY", cr2w, this);
				}
				return _inSectorCoordsY;
			}
			set
			{
				if (_inSectorCoordsY == value)
				{
					return;
				}
				_inSectorCoordsY = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("inSectorCoordsZ")] 
		public CUInt32 InSectorCoordsZ
		{
			get
			{
				if (_inSectorCoordsZ == null)
				{
					_inSectorCoordsZ = (CUInt32) CR2WTypeManager.Create("Uint32", "inSectorCoordsZ", cr2w, this);
				}
				return _inSectorCoordsZ;
			}
			set
			{
				if (_inSectorCoordsZ == value)
				{
					return;
				}
				_inSectorCoordsZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("generatorId")] 
		public CUInt32 GeneratorId
		{
			get
			{
				if (_generatorId == null)
				{
					_generatorId = (CUInt32) CR2WTypeManager.Create("Uint32", "generatorId", cr2w, this);
				}
				return _generatorId;
			}
			set
			{
				if (_generatorId == value)
				{
					return;
				}
				_generatorId = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("edgeMask")] 
		public CUInt8 EdgeMask
		{
			get
			{
				if (_edgeMask == null)
				{
					_edgeMask = (CUInt8) CR2WTypeManager.Create("Uint8", "edgeMask", cr2w, this);
				}
				return _edgeMask;
			}
			set
			{
				if (_edgeMask == value)
				{
					return;
				}
				_edgeMask = value;
				PropertySet(this);
			}
		}

		public worldAcousticSectorNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
