using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAIEvent : redEvent
	{
		private CName _name;
		private CFloat _timeToLive;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timeToLive")] 
		public CFloat TimeToLive
		{
			get
			{
				if (_timeToLive == null)
				{
					_timeToLive = (CFloat) CR2WTypeManager.Create("Float", "timeToLive", cr2w, this);
				}
				return _timeToLive;
			}
			set
			{
				if (_timeToLive == value)
				{
					return;
				}
				_timeToLive = value;
				PropertySet(this);
			}
		}

		public AIAIEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
