using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DEBUG_RebalanceItemEvent : redEvent
	{
		private CFloat _reqLevel;

		[Ordinal(0)] 
		[RED("reqLevel")] 
		public CFloat ReqLevel
		{
			get
			{
				if (_reqLevel == null)
				{
					_reqLevel = (CFloat) CR2WTypeManager.Create("Float", "reqLevel", cr2w, this);
				}
				return _reqLevel;
			}
			set
			{
				if (_reqLevel == value)
				{
					return;
				}
				_reqLevel = value;
				PropertySet(this);
			}
		}

		public DEBUG_RebalanceItemEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
