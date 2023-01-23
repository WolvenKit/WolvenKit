using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEnablePlayerGameplayLookAt_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questEnablePlayerGameplayLookAt_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
