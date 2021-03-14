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
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("coords")] 
		public CUInt64 Coords
		{
			get
			{
				if (_coords == null)
				{
					_coords = (CUInt64) CR2WTypeManager.Create("Uint64", "coords", cr2w, this);
				}
				return _coords;
			}
			set
			{
				if (_coords == value)
				{
					return;
				}
				_coords = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("buffer")] 
		public serializationDeferredDataBuffer Buffer
		{
			get
			{
				if (_buffer == null)
				{
					_buffer = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "buffer", cr2w, this);
				}
				return _buffer;
			}
			set
			{
				if (_buffer == value)
				{
					return;
				}
				_buffer = value;
				PropertySet(this);
			}
		}

		public worldInteriorMapNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
