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
			get
			{
				if (_perkType == null)
				{
					_perkType = (CEnum<gamedataPerkType>) CR2WTypeManager.Create("gamedataPerkType", "perkType", cr2w, this);
				}
				return _perkType;
			}
			set
			{
				if (_perkType == value)
				{
					return;
				}
				_perkType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("perkArea")] 
		public CEnum<gamedataPerkArea> PerkArea
		{
			get
			{
				if (_perkArea == null)
				{
					_perkArea = (CEnum<gamedataPerkArea>) CR2WTypeManager.Create("gamedataPerkArea", "perkArea", cr2w, this);
				}
				return _perkArea;
			}
			set
			{
				if (_perkArea == value)
				{
					return;
				}
				_perkArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("perkData")] 
		public CHandle<PerkDisplayData> PerkData
		{
			get
			{
				if (_perkData == null)
				{
					_perkData = (CHandle<PerkDisplayData>) CR2WTypeManager.Create("handle:PerkDisplayData", "perkData", cr2w, this);
				}
				return _perkData;
			}
			set
			{
				if (_perkData == value)
				{
					return;
				}
				_perkData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		public PerkTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
