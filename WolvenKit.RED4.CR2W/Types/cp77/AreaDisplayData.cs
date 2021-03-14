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

		[Ordinal(1)] 
		[RED("perks")] 
		public CArray<CHandle<PerkDisplayData>> Perks
		{
			get
			{
				if (_perks == null)
				{
					_perks = (CArray<CHandle<PerkDisplayData>>) CR2WTypeManager.Create("array:handle:PerkDisplayData", "perks", cr2w, this);
				}
				return _perks;
			}
			set
			{
				if (_perks == value)
				{
					return;
				}
				_perks = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("locked")] 
		public CBool Locked
		{
			get
			{
				if (_locked == null)
				{
					_locked = (CBool) CR2WTypeManager.Create("Bool", "locked", cr2w, this);
				}
				return _locked;
			}
			set
			{
				if (_locked == value)
				{
					return;
				}
				_locked = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("proficency")] 
		public CEnum<gamedataProficiencyType> Proficency
		{
			get
			{
				if (_proficency == null)
				{
					_proficency = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "proficency", cr2w, this);
				}
				return _proficency;
			}
			set
			{
				if (_proficency == value)
				{
					return;
				}
				_proficency = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("area")] 
		public CEnum<gamedataPerkArea> Area
		{
			get
			{
				if (_area == null)
				{
					_area = (CEnum<gamedataPerkArea>) CR2WTypeManager.Create("gamedataPerkArea", "area", cr2w, this);
				}
				return _area;
			}
			set
			{
				if (_area == value)
				{
					return;
				}
				_area = value;
				PropertySet(this);
			}
		}

		public AreaDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
