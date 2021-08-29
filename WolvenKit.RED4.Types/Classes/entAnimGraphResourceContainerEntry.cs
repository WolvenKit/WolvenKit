using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimGraphResourceContainerEntry : RedBaseClass
	{
		private CName _graphName;
		private CResourceReference<animAnimGraph> _animGraphResource;

		[Ordinal(0)] 
		[RED("graphName")] 
		public CName GraphName
		{
			get => GetProperty(ref _graphName);
			set => SetProperty(ref _graphName, value);
		}

		[Ordinal(1)] 
		[RED("animGraphResource")] 
		public CResourceReference<animAnimGraph> AnimGraphResource
		{
			get => GetProperty(ref _animGraphResource);
			set => SetProperty(ref _animGraphResource, value);
		}
	}
}
