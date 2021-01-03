using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DisposalDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("DisposalDeviceSetup")] public DisposalDeviceSetup DisposalDeviceSetup { get; set; }
		[Ordinal(1)]  [RED("distractionSetup")] public DistractionSetup DistractionSetup { get; set; }
		[Ordinal(2)]  [RED("explosionSetup")] public DistractionSetup ExplosionSetup { get; set; }
		[Ordinal(3)]  [RED("isDistractionDisabled")] public CBool IsDistractionDisabled { get; set; }
		[Ordinal(4)]  [RED("isPlayerCurrentlyPerformingDisposal")] public CBool IsPlayerCurrentlyPerformingDisposal { get; set; }
		[Ordinal(5)]  [RED("wasActivated")] public CBool WasActivated { get; set; }
		[Ordinal(6)]  [RED("wasLethalTakedownPerformed")] public CBool WasLethalTakedownPerformed { get; set; }

		public DisposalDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
