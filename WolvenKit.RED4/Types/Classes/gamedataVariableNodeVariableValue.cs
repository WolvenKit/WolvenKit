using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedataVariableNodeVariableValue : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("node")] 
		public CHandle<gamedataValueNode> Node
		{
			get => GetPropertyValue<CHandle<gamedataValueNode>>();
			set => SetPropertyValue<CHandle<gamedataValueNode>>(value);
		}

		[Ordinal(1)] 
		[RED("deriveInfo")] 
		public CEnum<gamedataVariableNodeVariableValueDeriveInfo> DeriveInfo
		{
			get => GetPropertyValue<CEnum<gamedataVariableNodeVariableValueDeriveInfo>>();
			set => SetPropertyValue<CEnum<gamedataVariableNodeVariableValueDeriveInfo>>(value);
		}

		public gamedataVariableNodeVariableValue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
