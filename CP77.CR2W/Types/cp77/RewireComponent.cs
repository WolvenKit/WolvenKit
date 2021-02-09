using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RewireComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("miniGameVideoPath")] public redResourceReferenceScriptToken MiniGameVideoPath { get; set; }
		[Ordinal(1)]  [RED("miniGameAudioEvent")] public CName MiniGameAudioEvent { get; set; }
		[Ordinal(2)]  [RED("miniGameVideoLenght")] public CFloat MiniGameVideoLenght { get; set; }
		[Ordinal(3)]  [RED("rewireEvent")] public CHandle<RewireEvent> RewireEvent { get; set; }
		[Ordinal(4)]  [RED("rewireCurrentLenght")] public CFloat RewireCurrentLenght { get; set; }
		[Ordinal(5)]  [RED("isActive")] public CBool IsActive { get; set; }

		public RewireComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
