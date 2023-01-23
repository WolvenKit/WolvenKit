using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCompiledCommunityAreaNode_Streamable : worldCompiledCommunityAreaNode
	{
		[Ordinal(6)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldCompiledCommunityAreaNode_Streamable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
