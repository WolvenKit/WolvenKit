using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedataGroupNodeGroupVariable : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("node")] 
		public CHandle<gamedataVariableNode> Node
		{
			get => GetPropertyValue<CHandle<gamedataVariableNode>>();
			set => SetPropertyValue<CHandle<gamedataVariableNode>>(value);
		}

		[Ordinal(1)] 
		[RED("deriveInfo")] 
		public CEnum<gamedataGroupNodeGroupVariableDeriveInfo> DeriveInfo
		{
			get => GetPropertyValue<CEnum<gamedataGroupNodeGroupVariableDeriveInfo>>();
			set => SetPropertyValue<CEnum<gamedataGroupNodeGroupVariableDeriveInfo>>(value);
		}

		[Ordinal(2)] 
		[RED("flattened")] 
		public CBool Flattened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("flatId")] 
		public TweakDBID FlatId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gamedataGroupNodeGroupVariable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
