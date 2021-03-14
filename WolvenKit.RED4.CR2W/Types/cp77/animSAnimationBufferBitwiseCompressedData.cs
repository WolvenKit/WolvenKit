using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSAnimationBufferBitwiseCompressedData : CVariable
	{
		private CFloat _dt;
		private CInt8 _compression;
		private CUInt16 _numFrames;
		private CUInt32 _dataAddr;
		private CUInt32 _dataAddrFallback;

		[Ordinal(0)] 
		[RED("dt")] 
		public CFloat Dt
		{
			get
			{
				if (_dt == null)
				{
					_dt = (CFloat) CR2WTypeManager.Create("Float", "dt", cr2w, this);
				}
				return _dt;
			}
			set
			{
				if (_dt == value)
				{
					return;
				}
				_dt = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("compression")] 
		public CInt8 Compression
		{
			get
			{
				if (_compression == null)
				{
					_compression = (CInt8) CR2WTypeManager.Create("Int8", "compression", cr2w, this);
				}
				return _compression;
			}
			set
			{
				if (_compression == value)
				{
					return;
				}
				_compression = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numFrames")] 
		public CUInt16 NumFrames
		{
			get
			{
				if (_numFrames == null)
				{
					_numFrames = (CUInt16) CR2WTypeManager.Create("Uint16", "numFrames", cr2w, this);
				}
				return _numFrames;
			}
			set
			{
				if (_numFrames == value)
				{
					return;
				}
				_numFrames = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dataAddr")] 
		public CUInt32 DataAddr
		{
			get
			{
				if (_dataAddr == null)
				{
					_dataAddr = (CUInt32) CR2WTypeManager.Create("Uint32", "dataAddr", cr2w, this);
				}
				return _dataAddr;
			}
			set
			{
				if (_dataAddr == value)
				{
					return;
				}
				_dataAddr = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("dataAddrFallback")] 
		public CUInt32 DataAddrFallback
		{
			get
			{
				if (_dataAddrFallback == null)
				{
					_dataAddrFallback = (CUInt32) CR2WTypeManager.Create("Uint32", "dataAddrFallback", cr2w, this);
				}
				return _dataAddrFallback;
			}
			set
			{
				if (_dataAddrFallback == value)
				{
					return;
				}
				_dataAddrFallback = value;
				PropertySet(this);
			}
		}

		public animSAnimationBufferBitwiseCompressedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
