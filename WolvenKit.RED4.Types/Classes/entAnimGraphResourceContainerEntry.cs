using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimGraphResourceContainerEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("graphName")] 
		public CName GraphName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("animGraphResource")] 
		public CResourceReference<animAnimGraph> AnimGraphResource
		{
			get => GetPropertyValue<CResourceReference<animAnimGraph>>();
			set => SetPropertyValue<CResourceReference<animAnimGraph>>(value);
		}
	}
}
