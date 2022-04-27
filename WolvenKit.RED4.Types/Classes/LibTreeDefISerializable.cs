using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeDefISerializable : RedBaseClass
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
		public CHandle<ISerializable> V
		{
			get => GetPropertyValue<CHandle<ISerializable>>();
			set => SetPropertyValue<CHandle<ISerializable>>(value);
		}

		public LibTreeDefISerializable()
		{
			VariableId = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
