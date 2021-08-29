using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataVariableNode : gamedataDataNode
	{
		private CName _hashedName;
		private CString _type;
		private CString _name;
		private CBool _isForeignKey;
		private CBool _isArray;
		private CBool _hasArrayValues;
		private CBool _isAddition;
		private CEnum<gamedataTweakDBType> _typeEnum;
		private CArray<gamedataVariableNodeVariableValue> _values;

		[Ordinal(3)] 
		[RED("hashedName")] 
		public CName HashedName
		{
			get => GetProperty(ref _hashedName);
			set => SetProperty(ref _hashedName, value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CString Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(5)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(6)] 
		[RED("isForeignKey")] 
		public CBool IsForeignKey
		{
			get => GetProperty(ref _isForeignKey);
			set => SetProperty(ref _isForeignKey, value);
		}

		[Ordinal(7)] 
		[RED("isArray")] 
		public CBool IsArray
		{
			get => GetProperty(ref _isArray);
			set => SetProperty(ref _isArray, value);
		}

		[Ordinal(8)] 
		[RED("hasArrayValues")] 
		public CBool HasArrayValues
		{
			get => GetProperty(ref _hasArrayValues);
			set => SetProperty(ref _hasArrayValues, value);
		}

		[Ordinal(9)] 
		[RED("isAddition")] 
		public CBool IsAddition
		{
			get => GetProperty(ref _isAddition);
			set => SetProperty(ref _isAddition, value);
		}

		[Ordinal(10)] 
		[RED("typeEnum")] 
		public CEnum<gamedataTweakDBType> TypeEnum
		{
			get => GetProperty(ref _typeEnum);
			set => SetProperty(ref _typeEnum, value);
		}

		[Ordinal(11)] 
		[RED("values")] 
		public CArray<gamedataVariableNodeVariableValue> Values
		{
			get => GetProperty(ref _values);
			set => SetProperty(ref _values, value);
		}
	}
}
