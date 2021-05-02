using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AreaDisplayData : IDisplayData
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

		public AreaDisplayData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
