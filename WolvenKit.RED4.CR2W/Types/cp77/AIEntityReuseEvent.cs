using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIEntityReuseEvent : AIAIEvent
	{
		private worldGlobalNodeID _destination;

		[Ordinal(2)] 
		[RED("destination")] 
		public worldGlobalNodeID Destination
		{
			get
			{
				if (_destination == null)
				{
					_destination = (worldGlobalNodeID) CR2WTypeManager.Create("worldGlobalNodeID", "destination", cr2w, this);
				}
				return _destination;
			}
			set
			{
				if (_destination == value)
				{
					return;
				}
				_destination = value;
				PropertySet(this);
			}
		}

		public AIEntityReuseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
