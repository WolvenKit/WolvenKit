using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCompiledSmartObjectsNode : worldNode
	{
		[Ordinal(4)] 
		[RED("resource")] 
		public CResourceAsyncReference<gameSmartObjectsCompiledResource> Resource
		{
			get => GetPropertyValue<CResourceAsyncReference<gameSmartObjectsCompiledResource>>();
			set => SetPropertyValue<CResourceAsyncReference<gameSmartObjectsCompiledResource>>(value);
		}
	}
}
