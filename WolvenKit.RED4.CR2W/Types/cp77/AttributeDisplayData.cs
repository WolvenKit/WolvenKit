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

		public AttributeDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
