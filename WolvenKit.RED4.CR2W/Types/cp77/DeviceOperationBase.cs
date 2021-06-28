using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceOperationBase : IScriptable
	{
		private CName _operationName;
		private CBool _executeOnce;
		private CBool _isEnabled;
		private CArray<SToggleDeviceOperationData> _toggleOperations;
		private CBool _disableDevice;

		[Ordinal(0)] 
		[RED("operationName")] 
		public CName OperationName
		{
			get => GetProperty(ref _operationName);
			set => SetProperty(ref _operationName, value);
		}

		[Ordinal(1)] 
		[RED("executeOnce")] 
		public CBool ExecuteOnce
		{
			get => GetProperty(ref _executeOnce);
			set => SetProperty(ref _executeOnce, value);
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(3)] 
		[RED("toggleOperations")] 
		public CArray<SToggleDeviceOperationData> ToggleOperations
		{
			get => GetProperty(ref _toggleOperations);
			set => SetProperty(ref _toggleOperations, value);
		}

		[Ordinal(4)] 
		[RED("disableDevice")] 
		public CBool DisableDevice
		{
			get => GetProperty(ref _disableDevice);
			set => SetProperty(ref _disableDevice, value);
		}

		public DeviceOperationBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
