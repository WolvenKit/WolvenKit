using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPreloadFX_NodeType : questIFXManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questPreloadFX_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questPreloadFX_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questPreloadFX_NodeTypeParams>>(value);
		}

		public questPreloadFX_NodeType()
		{
			Params = new() { new questPreloadFX_NodeTypeParams() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
