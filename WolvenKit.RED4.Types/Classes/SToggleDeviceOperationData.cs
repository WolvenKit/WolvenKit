using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SToggleDeviceOperationData : RedBaseClass
	{
		private CName _operationName;
		private CBool _enable;

		[Ordinal(0)] 
		[RED("operationName")] 
		public CName OperationName
		{
			get => GetProperty(ref _operationName);
			set => SetProperty(ref _operationName, value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}
	}
}
