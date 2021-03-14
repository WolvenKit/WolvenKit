using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimePeriod_ConditionType : questITimeConditionType
	{
		private GameTime _begin;
		private GameTime _end;

		[Ordinal(0)] 
		[RED("begin")] 
		public GameTime Begin
		{
			get
			{
				if (_begin == null)
				{
					_begin = (GameTime) CR2WTypeManager.Create("GameTime", "begin", cr2w, this);
				}
				return _begin;
			}
			set
			{
				if (_begin == value)
				{
					return;
				}
				_begin = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("end")] 
		public GameTime End
		{
			get
			{
				if (_end == null)
				{
					_end = (GameTime) CR2WTypeManager.Create("GameTime", "end", cr2w, this);
				}
				return _end;
			}
			set
			{
				if (_end == value)
				{
					return;
				}
				_end = value;
				PropertySet(this);
			}
		}

		public questTimePeriod_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
