using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BuyAttribute : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataStatType> _attributeType;
		private CBool _grantAttributePoint;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("grantAttributePoint")] 
		public CBool GrantAttributePoint
		{
			get
			{
				if (_grantAttributePoint == null)
				{
					_grantAttributePoint = (CBool) CR2WTypeManager.Create("Bool", "grantAttributePoint", cr2w, this);
				}
				return _grantAttributePoint;
			}
			set
			{
				if (_grantAttributePoint == value)
				{
					return;
				}
				_grantAttributePoint = value;
				PropertySet(this);
			}
		}

		public BuyAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
