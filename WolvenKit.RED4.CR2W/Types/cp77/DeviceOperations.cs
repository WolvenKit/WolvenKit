using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceOperations : IScriptable
	{
		private CArray<wCHandle<entIPlacedComponent>> _components;
		private CArray<SVfxInstanceData> _fxInstances;

		[Ordinal(0)] 
		[RED("components")] 
		public CArray<wCHandle<entIPlacedComponent>> Components
		{
			get
			{
				if (_components == null)
				{
					_components = (CArray<wCHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:whandle:entIPlacedComponent", "components", cr2w, this);
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

		[Ordinal(1)] 
		[RED("fxInstances")] 
		public CArray<SVfxInstanceData> FxInstances
		{
			get
			{
				if (_fxInstances == null)
				{
					_fxInstances = (CArray<SVfxInstanceData>) CR2WTypeManager.Create("array:SVfxInstanceData", "fxInstances", cr2w, this);
				}
				return _fxInstances;
			}
			set
			{
				if (_fxInstances == value)
				{
					return;
				}
				_fxInstances = value;
				PropertySet(this);
			}
		}

		public DeviceOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
