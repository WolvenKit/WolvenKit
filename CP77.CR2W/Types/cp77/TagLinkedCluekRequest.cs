using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TagLinkedCluekRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("linkedCluekData")] public LinkedFocusClueData LinkedCluekData { get; set; }
		[Ordinal(1)]  [RED("tag")] public CBool Tag { get; set; }

		public TagLinkedCluekRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
