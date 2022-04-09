using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeDefTreeVariablesList : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("list")] 
		public CArray<CHandle<LibTreeDefTreeVariable>> List
		{
			get => GetPropertyValue<CArray<CHandle<LibTreeDefTreeVariable>>>();
			set => SetPropertyValue<CArray<CHandle<LibTreeDefTreeVariable>>>(value);
		}

		public LibTreeDefTreeVariablesList()
		{
			List = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
