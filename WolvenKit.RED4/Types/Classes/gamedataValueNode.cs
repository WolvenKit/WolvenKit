using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedataValueNode : gamedataDataNode
	{
		[Ordinal(3)] 
		[RED("data")] 
		public CHandle<gamedataValueDataNode> Data
		{
			get => GetPropertyValue<CHandle<gamedataValueDataNode>>();
			set => SetPropertyValue<CHandle<gamedataValueDataNode>>(value);
		}

		[Ordinal(4)] 
		[RED("group")] 
		public CHandle<gamedataGroupNode> Group
		{
			get => GetPropertyValue<CHandle<gamedataGroupNode>>();
			set => SetPropertyValue<CHandle<gamedataGroupNode>>(value);
		}

		public gamedataValueNode()
		{
			NodeType = Enums.gamedataDataNodeType.Value;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
