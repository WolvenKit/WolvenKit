using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlaySoundDeviceOperation : DeviceOperationBase
	{
		private CArray<SSFXOperationData> _sFXs;

		[Ordinal(5)] 
		[RED("SFXs")] 
		public CArray<SSFXOperationData> SFXs
		{
			get
			{
				if (_sFXs == null)
				{
					_sFXs = (CArray<SSFXOperationData>) CR2WTypeManager.Create("array:SSFXOperationData", "SFXs", cr2w, this);
				}
				return _sFXs;
			}
			set
			{
				if (_sFXs == value)
				{
					return;
				}
				_sFXs = value;
				PropertySet(this);
			}
		}

		public PlaySoundDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
