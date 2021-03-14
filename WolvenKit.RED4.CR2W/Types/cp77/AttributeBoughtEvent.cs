using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttributeBoughtEvent : redEvent
	{
		private CEnum<gamedataStatType> _attributeType;

		[Ordinal(0)] 
		[RED("attributeType")] 
		public CEnum<gamedataStatType> AttributeType
		{
			get
			{
				if (_attributeType == null)
				{
					_attributeType = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "attributeType", cr2w, this);
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

		public AttributeBoughtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
