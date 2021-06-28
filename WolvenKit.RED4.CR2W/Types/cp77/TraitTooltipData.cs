using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TraitTooltipData : BasePerksMenuTooltipData
	{
		private CEnum<gamedataTraitType> _traitType;
		private TweakDBID _attributeId;
		private CEnum<gamedataProficiencyType> _proficiency;
		private CHandle<TraitDisplayData> _traitData;
		private CHandle<AttributeData> _attributeData;

		[Ordinal(1)] 
		[RED("traitType")] 
		public CEnum<gamedataTraitType> TraitType
		{
			get => GetProperty(ref _traitType);
			set => SetProperty(ref _traitType, value);
		}

		[Ordinal(2)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetProperty(ref _attributeId);
			set => SetProperty(ref _attributeId, value);
		}

		[Ordinal(3)] 
		[RED("proficiency")] 
		public CEnum<gamedataProficiencyType> Proficiency
		{
			get => GetProperty(ref _proficiency);
			set => SetProperty(ref _proficiency, value);
		}

		[Ordinal(4)] 
		[RED("traitData")] 
		public CHandle<TraitDisplayData> TraitData
		{
			get => GetProperty(ref _traitData);
			set => SetProperty(ref _traitData, value);
		}

		[Ordinal(5)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get => GetProperty(ref _attributeData);
			set => SetProperty(ref _attributeData, value);
		}

		public TraitTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
