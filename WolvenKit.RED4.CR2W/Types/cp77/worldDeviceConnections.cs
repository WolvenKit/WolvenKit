using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDeviceConnections : CVariable
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

		public worldDeviceConnections(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
