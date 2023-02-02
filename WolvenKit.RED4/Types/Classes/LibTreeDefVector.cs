using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeDefVector : RedBaseClass
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
		public Vector3 V
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public LibTreeDefVector()
		{
			VariableId = 65535;
			V = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
