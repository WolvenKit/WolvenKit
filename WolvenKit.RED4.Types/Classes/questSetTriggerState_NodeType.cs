using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetTriggerState_NodeType : questITriggerManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questSetTriggerState_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questSetTriggerState_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questSetTriggerState_NodeTypeParams>>(value);
		}

		public questSetTriggerState_NodeType()
		{
			Params = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
