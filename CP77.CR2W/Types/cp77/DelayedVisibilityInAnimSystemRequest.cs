using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DelayedVisibilityInAnimSystemRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("data")] public CHandle<ForcedVisibilityInAnimSystemData> Data { get; set; }
		[Ordinal(1)]  [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(2)]  [RED("isVisible")] public CBool IsVisible { get; set; }

		public DelayedVisibilityInAnimSystemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
