using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSceneTier3Data : gameSceneTierDataMotionConstrained
	{
		[Ordinal(8)] [RED("cameraSettings")] public gameTier3CameraSettings CameraSettings { get; set; }

		public gameSceneTier3Data(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
