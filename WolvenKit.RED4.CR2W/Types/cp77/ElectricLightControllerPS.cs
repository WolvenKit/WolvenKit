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
			get => GetProperty(ref _isConnectedToCLS);
			set => SetProperty(ref _isConnectedToCLS, value);
		}

		[Ordinal(104)] 
		[RED("wasCLSInitTriggered")] 
		public CBool WasCLSInitTriggered
		{
			get => GetProperty(ref _wasCLSInitTriggered);
			set => SetProperty(ref _wasCLSInitTriggered, value);
		}

		public ElectricLightControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
