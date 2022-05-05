using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCompiledCommunityAreaNode : worldNode
	{
		[Ordinal(4)] 
		[RED("area")] 
		public CHandle<communityArea> Area
		{
			get => GetPropertyValue<CHandle<communityArea>>();
			set => SetPropertyValue<CHandle<communityArea>>(value);
		}

		[Ordinal(5)] 
		[RED("sourceObjectId")] 
		public entEntityID SourceObjectId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public worldCompiledCommunityAreaNode()
		{
			SourceObjectId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
