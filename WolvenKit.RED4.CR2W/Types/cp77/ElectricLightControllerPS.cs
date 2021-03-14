using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElectricLightControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isConnectedToCLS;
		private CBool _wasCLSInitTriggered;

		[Ordinal(103)] 
		[RED("isConnectedToCLS")] 
		public CBool IsConnectedToCLS
		{
			get
			{
				if (_isConnectedToCLS == null)
				{
					_isConnectedToCLS = (CBool) CR2WTypeManager.Create("Bool", "isConnectedToCLS", cr2w, this);
				}
				return _isConnectedToCLS;
			}
			set
			{
				if (_isConnectedToCLS == value)
				{
					return;
				}
				_isConnectedToCLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("wasCLSInitTriggered")] 
		public CBool WasCLSInitTriggered
		{
			get
			{
				if (_wasCLSInitTriggered == null)
				{
					_wasCLSInitTriggered = (CBool) CR2WTypeManager.Create("Bool", "wasCLSInitTriggered", cr2w, this);
				}
				return _wasCLSInitTriggered;
			}
			set
			{
				if (_wasCLSInitTriggered == value)
				{
					return;
				}
				_wasCLSInitTriggered = value;
				PropertySet(this);
			}
		}

		public ElectricLightControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
