using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraTagEnemyLimitDataModule : GameSessionDataModule
	{
		[Ordinal(1)] [RED("cameraLimit")] public CInt32 CameraLimit { get; set; }
		[Ordinal(2)] [RED("cameraList")] public CArray<wCHandle<SurveillanceCamera>> CameraList { get; set; }

		public CameraTagEnemyLimitDataModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
