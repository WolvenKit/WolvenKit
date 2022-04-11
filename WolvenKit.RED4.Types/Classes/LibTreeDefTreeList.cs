using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeDefTreeList : RedBaseClass
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
		public CArray<CHandle<LibTreeCTreeReference>> V
		{
			get => GetPropertyValue<CArray<CHandle<LibTreeCTreeReference>>>();
			set => SetPropertyValue<CArray<CHandle<LibTreeCTreeReference>>>(value);
		}

		public LibTreeDefTreeList()
		{
			VariableId = 65535;
			V = new();
		}
	}
}
