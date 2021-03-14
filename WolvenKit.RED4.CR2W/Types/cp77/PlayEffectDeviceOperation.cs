using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayEffectDeviceOperation : DeviceOperationBase
	{
		private CArray<SVFXOperationData> _vFXs;
		private CArray<SVfxInstanceData> _fxInstances;

		[Ordinal(5)] 
		[RED("VFXs")] 
		public CArray<SVFXOperationData> VFXs
		{
			get
			{
				if (_vFXs == null)
				{
					_vFXs = (CArray<SVFXOperationData>) CR2WTypeManager.Create("array:SVFXOperationData", "VFXs", cr2w, this);
				}
				return _vFXs;
			}
			set
			{
				if (_vFXs == value)
				{
					return;
				}
				_vFXs = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		public PlayEffectDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
