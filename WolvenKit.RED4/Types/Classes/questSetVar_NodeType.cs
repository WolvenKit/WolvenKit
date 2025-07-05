using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetVar_NodeType : questIFactsDBManagerNodeType
	{
		[Ordinal(0)] 
		[RED("factName")] 
		public CString FactName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("setExactValue")] 
		public CBool SetExactValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSetVar_NodeType()
		{
			Value = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
