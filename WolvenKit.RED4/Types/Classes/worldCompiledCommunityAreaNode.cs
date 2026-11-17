using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCompiledCommunityAreaNode : worldNode
	{
		[Ordinal(2)] 
		[RED("area")] 
		public CHandle<communityArea> Area
		{
			get => GetPropertyValue<CHandle<communityArea>>();
			set => SetPropertyValue<CHandle<communityArea>>(value);
		}

		[Ordinal(3)] 
		[RED("sourceObjectId")] 
		public entEntityID SourceObjectId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public worldCompiledCommunityAreaNode()
		{
			SourceObjectId = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
