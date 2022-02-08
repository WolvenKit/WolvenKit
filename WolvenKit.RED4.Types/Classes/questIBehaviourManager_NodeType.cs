using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questIBehaviourManager_NodeType : questIRetNodeType
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}
	}
}
