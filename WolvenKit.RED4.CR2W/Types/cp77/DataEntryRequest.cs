using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataEntryRequest : gameScriptableSystemRequest
	{
		private CEnum<EGameSessionDataType> _dataType;
		private CVariant _data;

		[Ordinal(0)] 
		[RED("dataType")] 
		public CEnum<EGameSessionDataType> DataType
		{
			get
			{
				if (_dataType == null)
				{
					_dataType = (CEnum<EGameSessionDataType>) CR2WTypeManager.Create("EGameSessionDataType", "dataType", cr2w, this);
				}
				return _dataType;
			}
			set
			{
				if (_dataType == value)
				{
					return;
				}
				_dataType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CVariant Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CVariant) CR2WTypeManager.Create("Variant", "data", cr2w, this);
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

		public DataEntryRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
