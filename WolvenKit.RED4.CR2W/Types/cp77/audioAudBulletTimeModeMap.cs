using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudBulletTimeModeMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("bulletTimeMapItems")] public CArray<audioAudBulletTimeModeMapItem> BulletTimeMapItems { get; set; }

		public audioAudBulletTimeModeMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
