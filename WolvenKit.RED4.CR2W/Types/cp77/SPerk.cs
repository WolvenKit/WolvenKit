using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPerk : CVariable
	{
		private CEnum<gamedataPerkType> _type;
		private CInt32 _currLevel;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataPerkType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataPerkType>) CR2WTypeManager.Create("gamedataPerkType", "type", cr2w, this);
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
		[RED("currLevel")] 
		public CInt32 CurrLevel
		{
			get
			{
				if (_currLevel == null)
				{
					_currLevel = (CInt32) CR2WTypeManager.Create("Int32", "currLevel", cr2w, this);
				}
				return _currLevel;
			}
			set
			{
				if (_currLevel == value)
				{
					return;
				}
				_currLevel = value;
				PropertySet(this);
			}
		}

		public SPerk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
