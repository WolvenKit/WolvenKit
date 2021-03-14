using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Slave_Test : gameObject
	{
		private CHandle<PSD_Detector> _deviceComponent;

		[Ordinal(40)] 
		[RED("deviceComponent")] 
		public CHandle<PSD_Detector> DeviceComponent
		{
			get
			{
				if (_deviceComponent == null)
				{
					_deviceComponent = (CHandle<PSD_Detector>) CR2WTypeManager.Create("handle:PSD_Detector", "deviceComponent", cr2w, this);
				}
				return _deviceComponent;
			}
			set
			{
				if (_deviceComponent == value)
				{
					return;
				}
				_deviceComponent = value;
				PropertySet(this);
			}
		}

		public Slave_Test(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
