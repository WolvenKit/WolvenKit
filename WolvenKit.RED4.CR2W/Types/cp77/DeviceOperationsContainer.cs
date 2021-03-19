using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceOperationsContainer : IScriptable
	{
		private CArray<CHandle<DeviceOperationBase>> _operations;
		private CArray<CHandle<DeviceOperationsTrigger>> _triggers;

		[Ordinal(0)] 
		[RED("operations")] 
		public CArray<CHandle<DeviceOperationBase>> Operations
		{
			get => GetProperty(ref _operations);
			set => SetProperty(ref _operations, value);
		}

		[Ordinal(1)] 
		[RED("triggers")] 
		public CArray<CHandle<DeviceOperationsTrigger>> Triggers
		{
			get => GetProperty(ref _triggers);
			set => SetProperty(ref _triggers, value);
		}

		public DeviceOperationsContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
