using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class mathExprExpression : ISerializable
	{
		private CArray<CUInt32> _tokenData;
		private CArray<CFloat> _valuesData;
		private CUInt16 _returnVarType;

		[Ordinal(0)] 
		[RED("tokenData")] 
		public CArray<CUInt32> TokenData
		{
			get
			{
				if (_tokenData == null)
				{
					_tokenData = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "tokenData", cr2w, this);
				}
				return _tokenData;
			}
			set
			{
				if (_tokenData == value)
				{
					return;
				}
				_tokenData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("valuesData")] 
		public CArray<CFloat> ValuesData
		{
			get
			{
				if (_valuesData == null)
				{
					_valuesData = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "valuesData", cr2w, this);
				}
				return _valuesData;
			}
			set
			{
				if (_valuesData == value)
				{
					return;
				}
				_valuesData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("returnVarType")] 
		public CUInt16 ReturnVarType
		{
			get
			{
				if (_returnVarType == null)
				{
					_returnVarType = (CUInt16) CR2WTypeManager.Create("Uint16", "returnVarType", cr2w, this);
				}
				return _returnVarType;
			}
			set
			{
				if (_returnVarType == value)
				{
					return;
				}
				_returnVarType = value;
				PropertySet(this);
			}
		}

		public mathExprExpression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
