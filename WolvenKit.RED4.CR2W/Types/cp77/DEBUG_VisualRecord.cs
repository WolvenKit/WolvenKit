using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DEBUG_VisualRecord : CVariable
	{
		[Ordinal(0)] [RED("layerIDs")] public CArray<CUInt32> LayerIDs { get; set; }
		[Ordinal(1)] [RED("puppet")] public wCHandle<ScriptedPuppet> Puppet { get; set; }
		[Ordinal(2)] [RED("infiniteDuration")] public CBool InfiniteDuration { get; set; }
		[Ordinal(3)] [RED("showDuration")] public CFloat ShowDuration { get; set; }

		public DEBUG_VisualRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
