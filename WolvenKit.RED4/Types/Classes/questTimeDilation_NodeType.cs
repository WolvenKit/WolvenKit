using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTimeDilation_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<CHandle<questTimeDilation_NodeTypeParam>> Params
		{
			get => GetPropertyValue<CArray<CHandle<questTimeDilation_NodeTypeParam>>>();
			set => SetPropertyValue<CArray<CHandle<questTimeDilation_NodeTypeParam>>>(value);
		}

		public questTimeDilation_NodeType()
		{
			Params = new() { null };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
