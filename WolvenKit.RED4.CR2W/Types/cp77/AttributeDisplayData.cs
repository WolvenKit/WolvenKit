using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttributeDisplayData : IDisplayData
	{
		private TweakDBID _attributeId;
		private CArray<CHandle<ProficiencyDisplayData>> _proficiencies;

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
		[RED("proficiencies")] 
		public CArray<CHandle<ProficiencyDisplayData>> Proficiencies
		{
			get
			{
				if (_proficiencies == null)
				{
					_proficiencies = (CArray<CHandle<ProficiencyDisplayData>>) CR2WTypeManager.Create("array:handle:ProficiencyDisplayData", "proficiencies", cr2w, this);
				}
				return _proficiencies;
			}
			set
			{
				if (_proficiencies == value)
				{
					return;
				}
				_proficiencies = value;
				PropertySet(this);
			}
		}

		public AttributeDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
