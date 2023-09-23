using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerVisuals_OverridePlayerHairstyleAppearance : questICharacterManagerVisuals_NodeSubType
	{
		[Ordinal(0)] 
		[RED("hairstyleIndex")] 
		public CUInt32 HairstyleIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("hairstyleDefinitionName")] 
		public CName HairstyleDefinitionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("beardIndex")] 
		public CUInt32 BeardIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("beardPartIndex")] 
		public CUInt32 BeardPartIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("beardDefinitionName")] 
		public CName BeardDefinitionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questCharacterManagerVisuals_OverridePlayerHairstyleAppearance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
