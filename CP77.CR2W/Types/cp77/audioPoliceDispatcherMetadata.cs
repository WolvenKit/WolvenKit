using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioPoliceDispatcherMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("dispatcherTimeInterval")] public CFloat DispatcherTimeInterval { get; set; }
		[Ordinal(1)]  [RED("playerChaseBackupNeededInputs")] public CArray<CName> PlayerChaseBackupNeededInputs { get; set; }
		[Ordinal(2)]  [RED("playerChaseEndInputs")] public CArray<CName> PlayerChaseEndInputs { get; set; }
		[Ordinal(3)]  [RED("playerChaseStartInputs")] public CArray<CName> PlayerChaseStartInputs { get; set; }
		[Ordinal(4)]  [RED("regularInputs")] public CArray<CName> RegularInputs { get; set; }
		[Ordinal(5)]  [RED("sceneFilePath")] public CString SceneFilePath { get; set; }

		public audioPoliceDispatcherMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
