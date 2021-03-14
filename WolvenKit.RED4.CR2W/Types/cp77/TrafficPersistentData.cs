using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrafficPersistentData : CVariable
	{
		private CBool _invertTrafficEvents;

		[Ordinal(0)] 
		[RED("invertTrafficEvents")] 
		public CBool InvertTrafficEvents
		{
			get
			{
				if (_invertTrafficEvents == null)
				{
					_invertTrafficEvents = (CBool) CR2WTypeManager.Create("Bool", "invertTrafficEvents", cr2w, this);
				}
				return _invertTrafficEvents;
			}
			set
			{
				if (_invertTrafficEvents == value)
				{
					return;
				}
				_invertTrafficEvents = value;
				PropertySet(this);
			}
		}

		public TrafficPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
