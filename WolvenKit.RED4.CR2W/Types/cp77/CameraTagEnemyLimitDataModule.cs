using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraTagEnemyLimitDataModule : GameSessionDataModule
	{
		private CInt32 _cameraLimit;
		private CArray<wCHandle<SurveillanceCamera>> _cameraList;

		[Ordinal(1)] 
		[RED("cameraLimit")] 
		public CInt32 CameraLimit
		{
			get => GetProperty(ref _cameraLimit);
			set => SetProperty(ref _cameraLimit, value);
		}

		[Ordinal(2)] 
		[RED("cameraList")] 
		public CArray<wCHandle<SurveillanceCamera>> CameraList
		{
			get => GetProperty(ref _cameraList);
			set => SetProperty(ref _cameraList, value);
		}

		public CameraTagEnemyLimitDataModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
