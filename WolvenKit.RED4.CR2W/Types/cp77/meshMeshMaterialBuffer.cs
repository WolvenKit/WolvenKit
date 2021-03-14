using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshMaterialBuffer : CVariable
	{
		private DataBuffer _rawData;
		private CArray<meshLocalMaterialHeader> _rawDataHeaders;

		[Ordinal(0)] 
		[RED("rawData")] 
		public DataBuffer RawData
		{
			get
			{
				if (_rawData == null)
				{
					_rawData = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "rawData", cr2w, this);
				}
				return _rawData;
			}
			set
			{
				if (_rawData == value)
				{
					return;
				}
				_rawData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rawDataHeaders")] 
		public CArray<meshLocalMaterialHeader> RawDataHeaders
		{
			get
			{
				if (_rawDataHeaders == null)
				{
					_rawDataHeaders = (CArray<meshLocalMaterialHeader>) CR2WTypeManager.Create("array:meshLocalMaterialHeader", "rawDataHeaders", cr2w, this);
				}
				return _rawDataHeaders;
			}
			set
			{
				if (_rawDataHeaders == value)
				{
					return;
				}
				_rawDataHeaders = value;
				PropertySet(this);
			}
		}

		public meshMeshMaterialBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
