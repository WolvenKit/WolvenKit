using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SStatPoolValue : CVariable
	{
		private CEnum<gamedataStatPoolType> _type;
		private CFloat _value;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataStatPoolType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "type", cr2w, this);
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

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CFloat) CR2WTypeManager.Create("Float", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public SStatPoolValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
