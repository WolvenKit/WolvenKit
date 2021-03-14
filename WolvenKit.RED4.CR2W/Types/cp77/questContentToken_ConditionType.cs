using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questContentToken_ConditionType : questIContentConditionType
	{
		private CEnum<questQuestContentType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<questQuestContentType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<questQuestContentType>) CR2WTypeManager.Create("questQuestContentType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public questContentToken_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
