using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameIMovingPlatformMovement : IScriptable
	{
		[Ordinal(0)] 
		[RED("initData")] 
		public gameIMovingPlatformMovementInitData InitData
		{
			get => GetPropertyValue<gameIMovingPlatformMovementInitData>();
			set => SetPropertyValue<gameIMovingPlatformMovementInitData>(value);
		}

		[Ordinal(1)] 
		[RED("endNode")] 
		public NodeRef EndNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public gameIMovingPlatformMovement()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
