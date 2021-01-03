using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CameraDeadBodySessionDataModule : GameSessionDataModule
	{
		[Ordinal(0)]  [RED("cameraDeadBodyData")] public CArray<CHandle<CameraDeadBodyInternalData>> CameraDeadBodyData { get; set; }

		public CameraDeadBodySessionDataModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
