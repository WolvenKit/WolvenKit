using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPlayFX_NodeType : questIFXManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questPlayFX_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questPlayFX_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questPlayFX_NodeTypeParams>>(value);
		}

		public questPlayFX_NodeType()
		{
			Params = new() { new questPlayFX_NodeTypeParams() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
