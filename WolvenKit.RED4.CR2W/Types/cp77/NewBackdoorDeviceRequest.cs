using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewBackdoorDeviceRequest : gameScriptableSystemRequest
	{
		private CHandle<ScriptableDeviceComponentPS> _device;

		[Ordinal(0)] 
		[RED("device")] 
		public CHandle<ScriptableDeviceComponentPS> Device
		{
			get
			{
				if (_device == null)
				{
					_device = (CHandle<ScriptableDeviceComponentPS>) CR2WTypeManager.Create("handle:ScriptableDeviceComponentPS", "device", cr2w, this);
				}
				return _device;
			}
			set
			{
				if (_device == value)
				{
					return;
				}
				_device = value;
				PropertySet(this);
			}
		}

		public NewBackdoorDeviceRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
