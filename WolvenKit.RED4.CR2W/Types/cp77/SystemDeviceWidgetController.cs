using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SystemDeviceWidgetController : DeviceWidgetControllerBase
	{
		private inkTextWidgetReference _slavesConnectedCount;

		[Ordinal(10)] 
		[RED("slavesConnectedCount")] 
		public inkTextWidgetReference SlavesConnectedCount
		{
			get
			{
				if (_slavesConnectedCount == null)
				{
					_slavesConnectedCount = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "slavesConnectedCount", cr2w, this);
				}
				return _slavesConnectedCount;
			}
			set
			{
				if (_slavesConnectedCount == value)
				{
					return;
				}
				_slavesConnectedCount = value;
				PropertySet(this);
			}
		}

		public SystemDeviceWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
