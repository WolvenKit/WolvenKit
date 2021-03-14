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
			get
			{
				if (_components == null)
				{
					_components = (CArray<SComponentOperationData>) CR2WTypeManager.Create("array:SComponentOperationData", "components", cr2w, this);
				}
				return _components;
			}
			set
			{
				if (_components == value)
				{
					return;
				}
				_components = value;
				PropertySet(this);
			}
		}

		public ToggleComponentsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
