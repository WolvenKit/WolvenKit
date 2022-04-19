using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetDebugView_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<questEDebugViewMode> Mode
		{
			get => GetPropertyValue<CEnum<questEDebugViewMode>>();
			set => SetPropertyValue<CEnum<questEDebugViewMode>>(value);
		}

		public questSetDebugView_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
