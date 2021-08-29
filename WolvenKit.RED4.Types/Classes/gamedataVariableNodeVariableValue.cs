using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataVariableNodeVariableValue : RedBaseClass
	{
		private CHandle<gamedataValueNode> _node;
		private CEnum<gamedataVariableNodeVariableValueDeriveInfo> _deriveInfo;

		[Ordinal(0)] 
		[RED("node")] 
		public CHandle<gamedataValueNode> Node
		{
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}

		[Ordinal(1)] 
		[RED("deriveInfo")] 
		public CEnum<gamedataVariableNodeVariableValueDeriveInfo> DeriveInfo
		{
			get => GetProperty(ref _deriveInfo);
			set => SetProperty(ref _deriveInfo, value);
		}
	}
}
