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

		[Ordinal(2)] 
		[RED("attributeType")] 
		public CEnum<PerkMenuAttribute> AttributeType
		{
			get
			{
				if (_attributeType == null)
				{
					_attributeType = (CEnum<PerkMenuAttribute>) CR2WTypeManager.Create("PerkMenuAttribute", "attributeType", cr2w, this);
				}
				return _attributeType;
			}
			set
			{
				if (_attributeType == value)
				{
					return;
				}
				_attributeType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("displayData")] 
		public CHandle<AttributeDisplayData> DisplayData
		{
			get
			{
				if (_displayData == null)
				{
					_displayData = (CHandle<AttributeDisplayData>) CR2WTypeManager.Create("handle:AttributeDisplayData", "displayData", cr2w, this);
				}
				return _displayData;
			}
			set
			{
				if (_displayData == value)
				{
					return;
				}
				_displayData = value;
				PropertySet(this);
			}
		}

		public AttributeTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
