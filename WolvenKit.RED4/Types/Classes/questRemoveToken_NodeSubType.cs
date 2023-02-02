using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRemoveToken_NodeSubType : questIContentTokenManager_NodeSubType
	{
		[Ordinal(0)] 
		[RED("removeAll")] 
		public CBool RemoveAll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questRemoveToken_NodeSubType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
