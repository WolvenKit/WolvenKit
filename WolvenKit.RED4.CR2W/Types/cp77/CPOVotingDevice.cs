using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CPOVotingDevice : CPOMissionDevice
	{
		private CName _deviceName;

		[Ordinal(45)] 
		[RED("deviceName")] 
		public CName DeviceName
		{
			get
			{
				if (_deviceName == null)
				{
					_deviceName = (CName) CR2WTypeManager.Create("CName", "deviceName", cr2w, this);
				}
				return _deviceName;
			}
			set
			{
				if (_deviceName == value)
				{
					return;
				}
				_deviceName = value;
				PropertySet(this);
			}
		}

		public CPOVotingDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
