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
			get => GetProperty(ref _cameraDeadBodyData);
			set => SetProperty(ref _cameraDeadBodyData, value);
		}

		public CameraDeadBodySessionDataModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
