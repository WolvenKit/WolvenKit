using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttributeTooltipData : BasePerksMenuTooltipData
	{
		private TweakDBID _attributeId;
		private CEnum<PerkMenuAttribute> _attributeType;
		private CHandle<AttributeData> _attributeData;
		private CHandle<AttributeDisplayData> _displayData;

		[Ordinal(1)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetProperty(ref _attributeId);
			set => SetProperty(ref _attributeId, value);
		}

		[Ordinal(2)] 
		[RED("attributeType")] 
		public CEnum<PerkMenuAttribute> AttributeType
		{
			get => GetProperty(ref _attributeType);
			set => SetProperty(ref _attributeType, value);
		}

		[Ordinal(3)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get => GetProperty(ref _attributeData);
			set => SetProperty(ref _attributeData, value);
		}

		[Ordinal(4)] 
		[RED("displayData")] 
		public CHandle<AttributeDisplayData> DisplayData
		{
			get => GetProperty(ref _displayData);
			set => SetProperty(ref _displayData, value);
		}

		public AttributeTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
