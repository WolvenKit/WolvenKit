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
			get
			{
				if (_traitType == null)
				{
					_traitType = (CEnum<gamedataTraitType>) CR2WTypeManager.Create("gamedataTraitType", "traitType", cr2w, this);
				}
				return _traitType;
			}
			set
			{
				if (_traitType == value)
				{
					return;
				}
				_traitType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get
			{
				if (_attributeId == null)
				{
					_attributeId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attributeId", cr2w, this);
				}
				return _attributeId;
			}
			set
			{
				if (_attributeId == value)
				{
					return;
				}
				_attributeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("proficiency")] 
		public CEnum<gamedataProficiencyType> Proficiency
		{
			get
			{
				if (_proficiency == null)
				{
					_proficiency = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "proficiency", cr2w, this);
				}
				return _proficiency;
			}
			set
			{
				if (_proficiency == value)
				{
					return;
				}
				_proficiency = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("traitData")] 
		public CHandle<TraitDisplayData> TraitData
		{
			get
			{
				if (_traitData == null)
				{
					_traitData = (CHandle<TraitDisplayData>) CR2WTypeManager.Create("handle:TraitDisplayData", "traitData", cr2w, this);
				}
				return _traitData;
			}
			set
			{
				if (_traitData == value)
				{
					return;
				}
				_traitData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get
			{
				if (_attributeData == null)
				{
					_attributeData = (CHandle<AttributeData>) CR2WTypeManager.Create("handle:AttributeData", "attributeData", cr2w, this);
				}
				return _attributeData;
			}
			set
			{
				if (_attributeData == value)
				{
					return;
				}
				_attributeData = value;
				PropertySet(this);
			}
		}

		public TraitTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
