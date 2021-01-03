using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CanPlayerHijackMountedNpcPrereqState : gamePrereqState
	{
		[Ordinal(0)]  [RED("mountingListener")] public CHandle<gameScriptedPrereqMountingListenerWrapper> MountingListener { get; set; }

		public CanPlayerHijackMountedNpcPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
