using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questBlockTokenActivation_NodeSubType : questIContentTokenManager_NodeSubType
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questBlockAction> Action
		{
			get => GetPropertyValue<CEnum<questBlockAction>>();
			set => SetPropertyValue<CEnum<questBlockAction>>(value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("resetTokenSpawnTimer")] 
		public CBool ResetTokenSpawnTimer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questBlockTokenActivation_NodeSubType()
		{
			ResetTokenSpawnTimer = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
