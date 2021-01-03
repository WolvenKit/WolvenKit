using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UploadFromNPCToNPCListener : QuickHackUploadListener
	{
		[Ordinal(0)]  [RED("npcPuppet")] public wCHandle<ScriptedPuppet> NpcPuppet { get; set; }

		public UploadFromNPCToNPCListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
