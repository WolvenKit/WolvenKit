using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CameraTagEnemyLimitDataModule : GameSessionDataModule
	{
		[Ordinal(0)]  [RED("cameraLimit")] public CInt32 CameraLimit { get; set; }
		[Ordinal(1)]  [RED("cameraList")] public CArray<wCHandle<SurveillanceCamera>> CameraList { get; set; }

		public CameraTagEnemyLimitDataModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
