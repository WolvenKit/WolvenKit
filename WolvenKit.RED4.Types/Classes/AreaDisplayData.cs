using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AreaDisplayData : IDisplayData
	{
		private TweakDBID _attributeId;
		private CArray<CHandle<PerkDisplayData>> _perks;
		private CBool _locked;
		private CEnum<gamedataProficiencyType> _proficency;
		private CEnum<gamedataPerkArea> _area;

		[Ordinal(0)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetProperty(ref _attributeId);
			set => SetProperty(ref _attributeId, value);
		}

		[Ordinal(1)] 
		[RED("perks")] 
		public CArray<CHandle<PerkDisplayData>> Perks
		{
			get => GetProperty(ref _perks);
			set => SetProperty(ref _perks, value);
		}

		[Ordinal(2)] 
		[RED("locked")] 
		public CBool Locked
		{
			get => GetProperty(ref _locked);
			set => SetProperty(ref _locked, value);
		}

		[Ordinal(3)] 
		[RED("proficency")] 
		public CEnum<gamedataProficiencyType> Proficency
		{
			get => GetProperty(ref _proficency);
			set => SetProperty(ref _proficency, value);
		}

		[Ordinal(4)] 
		[RED("area")] 
		public CEnum<gamedataPerkArea> Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}
	}
}
