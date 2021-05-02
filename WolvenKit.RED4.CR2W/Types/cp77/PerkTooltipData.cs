using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkTooltipData : BasePerksMenuTooltipData
	{
		private CEnum<gamedataPerkType> _perkType;
		private CEnum<gamedataPerkArea> _perkArea;
		private TweakDBID _attributeId;
		private CEnum<gamedataProficiencyType> _proficiency;
		private CHandle<PerkDisplayData> _perkData;
		private CHandle<AttributeData> _attributeData;

		[Ordinal(1)] 
		[RED("perkType")] 
		public CEnum<gamedataPerkType> PerkType
		{
			get => GetProperty(ref _perkType);
			set => SetProperty(ref _perkType, value);
		}

		[Ordinal(2)] 
		[RED("perkArea")] 
		public CEnum<gamedataPerkArea> PerkArea
		{
			get => GetProperty(ref _perkArea);
			set => SetProperty(ref _perkArea, value);
		}

		[Ordinal(3)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetProperty(ref _attributeId);
			set => SetProperty(ref _attributeId, value);
		}

		[Ordinal(4)] 
		[RED("proficiency")] 
		public CEnum<gamedataProficiencyType> Proficiency
		{
			get => GetProperty(ref _proficiency);
			set => SetProperty(ref _proficiency, value);
		}

		[Ordinal(5)] 
		[RED("perkData")] 
		public CHandle<PerkDisplayData> PerkData
		{
			get => GetProperty(ref _perkData);
			set => SetProperty(ref _perkData, value);
		}

		[Ordinal(6)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get => GetProperty(ref _attributeData);
			set => SetProperty(ref _attributeData, value);
		}

		public PerkTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
