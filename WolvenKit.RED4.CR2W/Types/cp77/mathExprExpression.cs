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
			get => GetProperty(ref _tokenData);
			set => SetProperty(ref _tokenData, value);
		}

		[Ordinal(1)] 
		[RED("valuesData")] 
		public CArray<CFloat> ValuesData
		{
			get => GetProperty(ref _valuesData);
			set => SetProperty(ref _valuesData, value);
		}

		[Ordinal(2)] 
		[RED("returnVarType")] 
		public CUInt16 ReturnVarType
		{
			get => GetProperty(ref _returnVarType);
			set => SetProperty(ref _returnVarType, value);
		}

		public mathExprExpression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
