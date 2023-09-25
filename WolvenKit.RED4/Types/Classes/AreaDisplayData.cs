using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AreaDisplayData : IDisplayData
	{
		[Ordinal(0)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("perks")] 
		public CArray<CHandle<PerkDisplayData>> Perks
		{
			get => GetPropertyValue<CArray<CHandle<PerkDisplayData>>>();
			set => SetPropertyValue<CArray<CHandle<PerkDisplayData>>>(value);
		}

		[Ordinal(2)] 
		[RED("locked")] 
		public CBool Locked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("proficency")] 
		public CEnum<gamedataProficiencyType> Proficency
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		[Ordinal(4)] 
		[RED("area")] 
		public CEnum<gamedataPerkArea> Area
		{
			get => GetPropertyValue<CEnum<gamedataPerkArea>>();
			set => SetPropertyValue<CEnum<gamedataPerkArea>>(value);
		}

		public AreaDisplayData()
		{
			Perks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
