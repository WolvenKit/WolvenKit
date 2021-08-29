using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SWorkspotData : RedBaseClass
	{
		private CName _componentName;
		private CBool _freeCamera;
		private CEnum<EWorkspotOperationType> _operationType;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(1)] 
		[RED("freeCamera")] 
		public CBool FreeCamera
		{
			get => GetProperty(ref _freeCamera);
			set => SetProperty(ref _freeCamera, value);
		}

		[Ordinal(2)] 
		[RED("operationType")] 
		public CEnum<EWorkspotOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}
	}
}
