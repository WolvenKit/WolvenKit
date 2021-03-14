using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraDeadBodySessionDataModule : GameSessionDataModule
	{
		private CArray<CHandle<CameraDeadBodyInternalData>> _cameraDeadBodyData;

		[Ordinal(1)] 
		[RED("cameraDeadBodyData")] 
		public CArray<CHandle<CameraDeadBodyInternalData>> CameraDeadBodyData
		{
			get
			{
				if (_cameraDeadBodyData == null)
				{
					_cameraDeadBodyData = (CArray<CHandle<CameraDeadBodyInternalData>>) CR2WTypeManager.Create("array:handle:CameraDeadBodyInternalData", "cameraDeadBodyData", cr2w, this);
				}
				return _cameraDeadBodyData;
			}
			set
			{
				if (_cameraDeadBodyData == value)
				{
					return;
				}
				_cameraDeadBodyData = value;
				PropertySet(this);
			}
		}

		public CameraDeadBodySessionDataModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
