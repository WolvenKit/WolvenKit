using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Root : animAnimNode_Container
	{
		[Ordinal(12)] 
		[RED("outputNode")] 
		public animPoseLink OutputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_Root()
		{
			Id = 4294967295;
			Nodes = new();
			OutputNode = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
