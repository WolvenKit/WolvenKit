using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeDefBool : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("variableId")] 
		public CUInt16 VariableId
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("treeVariable")] 
		public CName TreeVariable
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("v")] 
		public CBool V
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LibTreeDefBool()
		{
			VariableId = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
