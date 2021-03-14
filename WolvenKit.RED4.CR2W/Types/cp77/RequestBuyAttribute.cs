using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestBuyAttribute : redEvent
	{
		private CEnum<gamedataStatType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataStatType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "type", cr2w, this);
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

		public RequestBuyAttribute(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
