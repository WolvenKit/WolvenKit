using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioAudBulletTimeModeMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("bulletTimeMapItems")] public CArray<audioAudBulletTimeModeMapItem> BulletTimeMapItems { get; set; }

		public audioAudBulletTimeModeMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
