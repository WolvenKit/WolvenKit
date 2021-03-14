using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITimeoutCondition : AITimeCondition
	{
		private CFloat _timestamp;

		[Ordinal(0)] 
		[RED("timestamp")] 
		public CFloat Timestamp
		{
			get
			{
				if (_timestamp == null)
				{
					_timestamp = (CFloat) CR2WTypeManager.Create("Float", "timestamp", cr2w, this);
				}
				return _timestamp;
			}
			set
			{
				if (_timestamp == value)
				{
					return;
				}
				_timestamp = value;
				PropertySet(this);
			}
		}

		public AITimeoutCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
