using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIMovingPlatformMovementInitData : RedBaseClass
	{
		private CEnum<gameMovingPlatformMovementInitializationType> _initType;
		private CFloat _initValue;
		private NodeRef _startNode;
		private NodeRef _endNode;

		[Ordinal(0)] 
		[RED("initType")] 
		public CEnum<gameMovingPlatformMovementInitializationType> InitType
		{
			get => GetProperty(ref _initType);
			set => SetProperty(ref _initType, value);
		}

		[Ordinal(1)] 
		[RED("initValue")] 
		public CFloat InitValue
		{
			get => GetProperty(ref _initValue);
			set => SetProperty(ref _initValue, value);
		}

		[Ordinal(2)] 
		[RED("startNode")] 
		public NodeRef StartNode
		{
			get => GetProperty(ref _startNode);
			set => SetProperty(ref _startNode, value);
		}

		[Ordinal(3)] 
		[RED("endNode")] 
		public NodeRef EndNode
		{
			get => GetProperty(ref _endNode);
			set => SetProperty(ref _endNode, value);
		}
	}
}
