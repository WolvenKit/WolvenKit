using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDeviceConnections : RedBaseClass
	{
		private CName _deviceClassName;
		private CArray<NodeRef> _nodeRefs;

		[Ordinal(0)] 
		[RED("deviceClassName")] 
		public CName DeviceClassName
		{
			get => GetProperty(ref _deviceClassName);
			set => SetProperty(ref _deviceClassName, value);
		}

		[Ordinal(1)] 
		[RED("nodeRefs")] 
		public CArray<NodeRef> NodeRefs
		{
			get => GetProperty(ref _nodeRefs);
			set => SetProperty(ref _nodeRefs, value);
		}
	}
}
