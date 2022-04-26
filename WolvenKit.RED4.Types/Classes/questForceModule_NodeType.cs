using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questForceModule_NodeType : questIVisionModeNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questForceVMModule_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questForceVMModule_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questForceVMModule_NodeTypeParams>>(value);
		}

		public questForceModule_NodeType()
		{
			Params = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
