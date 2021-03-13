using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RewireComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("miniGameVideoPath")] public redResourceReferenceScriptToken MiniGameVideoPath { get; set; }
		[Ordinal(6)] [RED("miniGameAudioEvent")] public CName MiniGameAudioEvent { get; set; }
		[Ordinal(7)] [RED("miniGameVideoLenght")] public CFloat MiniGameVideoLenght { get; set; }
		[Ordinal(8)] [RED("rewireEvent")] public CHandle<RewireEvent> RewireEvent { get; set; }
		[Ordinal(9)] [RED("rewireCurrentLenght")] public CFloat RewireCurrentLenght { get; set; }
		[Ordinal(10)] [RED("isActive")] public CBool IsActive { get; set; }

		public RewireComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
