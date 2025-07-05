using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedataVariableNode : gamedataDataNode
	{
		[Ordinal(3)] 
		[RED("hashedName")] 
		public CName HashedName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CString Type
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("isForeignKey")] 
		public CBool IsForeignKey
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isArray")] 
		public CBool IsArray
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("hasArrayValues")] 
		public CBool HasArrayValues
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isAddition")] 
		public CBool IsAddition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("typeEnum")] 
		public CEnum<gamedataTweakDBType> TypeEnum
		{
			get => GetPropertyValue<CEnum<gamedataTweakDBType>>();
			set => SetPropertyValue<CEnum<gamedataTweakDBType>>(value);
		}

		[Ordinal(11)] 
		[RED("values")] 
		public CArray<gamedataVariableNodeVariableValue> Values
		{
			get => GetPropertyValue<CArray<gamedataVariableNodeVariableValue>>();
			set => SetPropertyValue<CArray<gamedataVariableNodeVariableValue>>(value);
		}

		public gamedataVariableNode()
		{
			NodeType = Enums.gamedataDataNodeType.Variable;
			Values = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
