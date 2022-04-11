using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSmartObjectNode : worldNode
	{
		[Ordinal(4)] 
		[RED("object")] 
		public CHandle<gameSmartObjectDefinition> Object
		{
			get => GetPropertyValue<CHandle<gameSmartObjectDefinition>>();
			set => SetPropertyValue<CHandle<gameSmartObjectDefinition>>(value);
		}
	}
}
