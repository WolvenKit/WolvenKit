using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetDebugView_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<questEDebugViewMode> Mode
		{
			get => GetPropertyValue<CEnum<questEDebugViewMode>>();
			set => SetPropertyValue<CEnum<questEDebugViewMode>>(value);
		}
	}
}
