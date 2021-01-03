using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnEventBlendWorkspotSetupParameters : ISerializable
	{
		[Ordinal(0)]  [RED("idleOnlyMode")] public CBool IdleOnlyMode { get; set; }
		[Ordinal(1)]  [RED("itemOverride")] public workWorkspotItemOverride ItemOverride { get; set; }
		[Ordinal(2)]  [RED("sequenceEntryId")] public workWorkEntryId SequenceEntryId { get; set; }
		[Ordinal(3)]  [RED("workExcludedGestures")] public CArray<workWorkEntryId> WorkExcludedGestures { get; set; }
		[Ordinal(4)]  [RED("workspotId")] public scnSceneWorkspotInstanceId WorkspotId { get; set; }

		public scnEventBlendWorkspotSetupParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
