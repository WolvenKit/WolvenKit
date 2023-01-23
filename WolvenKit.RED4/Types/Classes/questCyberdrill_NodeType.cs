using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCyberdrill_NodeType : questIInteractiveObjectManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questCyberdrill_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questCyberdrill_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questCyberdrill_NodeTypeParams>>(value);
		}

		public questCyberdrill_NodeType()
		{
			Params = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
