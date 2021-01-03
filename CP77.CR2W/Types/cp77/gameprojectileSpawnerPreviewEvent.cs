using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSpawnerPreviewEvent : redEvent
	{
		[Ordinal(0)]  [RED("previewActive")] public CBool PreviewActive { get; set; }

		public gameprojectileSpawnerPreviewEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
