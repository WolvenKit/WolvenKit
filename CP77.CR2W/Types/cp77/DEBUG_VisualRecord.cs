using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DEBUG_VisualRecord : CVariable
	{
		[Ordinal(0)]  [RED("infiniteDuration")] public CBool InfiniteDuration { get; set; }
		[Ordinal(1)]  [RED("layerIDs")] public CArray<CUInt32> LayerIDs { get; set; }
		[Ordinal(2)]  [RED("puppet")] public wCHandle<ScriptedPuppet> Puppet { get; set; }
		[Ordinal(3)]  [RED("showDuration")] public CFloat ShowDuration { get; set; }

		public DEBUG_VisualRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
