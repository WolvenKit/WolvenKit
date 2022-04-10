using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AttributeDisplayData : IDisplayData
	{
		[Ordinal(0)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("proficiencies")] 
		public CArray<CHandle<ProficiencyDisplayData>> Proficiencies
		{
			get => GetPropertyValue<CArray<CHandle<ProficiencyDisplayData>>>();
			set => SetPropertyValue<CArray<CHandle<ProficiencyDisplayData>>>(value);
		}

		public AttributeDisplayData()
		{
			Proficiencies = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
