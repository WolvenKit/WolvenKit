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
			Id = uint.MaxValue;
			Nodes = new();
			OutputNode = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
