using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDeviceRef : RedBaseClass
	{
		private NodeRef _nodeRef;
		private CName _componentName;
		private CName _deviceClassName;

		[Ordinal(0)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(1)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(2)] 
		[RED("deviceClassName")] 
		public CName DeviceClassName
		{
			get => GetProperty(ref _deviceClassName);
			set => SetProperty(ref _deviceClassName, value);
		}

		public worldDeviceRef()
		{
			_componentName = "controller";
		}
	}
}
