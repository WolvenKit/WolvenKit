using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AttributeDisplayData : IDisplayData
	{
		private TweakDBID _attributeId;
		private CArray<CHandle<ProficiencyDisplayData>> _proficiencies;

		[Ordinal(0)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetProperty(ref _attributeId);
			set => SetProperty(ref _attributeId, value);
		}

		[Ordinal(1)] 
		[RED("proficiencies")] 
		public CArray<CHandle<ProficiencyDisplayData>> Proficiencies
		{
			get => GetProperty(ref _proficiencies);
			set => SetProperty(ref _proficiencies, value);
		}
	}
}
