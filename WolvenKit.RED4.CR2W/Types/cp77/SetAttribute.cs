using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetAttribute : gamePlayerScriptableSystemRequest
	{
		private CFloat _statLevel;
		private CEnum<gamedataStatType> _attributeType;

		[Ordinal(1)] 
		[RED("statLevel")] 
		public CFloat StatLevel
		{
			get
			{
				if (_statLevel == null)
				{
					_statLevel = (CFloat) CR2WTypeManager.Create("Float", "statLevel", cr2w, this);
				}
				return _statLevel;
			}
			set
			{
				if (_statLevel == value)
				{
					return;
				}
				_statLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public SetAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
