using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleComponentsDeviceOperation : DeviceOperationBase
	{
		private CArray<SComponentOperationData> _components;

		[Ordinal(5)] 
		[RED("components")] 
		public CArray<SComponentOperationData> Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}

		public ToggleComponentsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
