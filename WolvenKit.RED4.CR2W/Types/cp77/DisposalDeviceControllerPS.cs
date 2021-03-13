using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisposalDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("DisposalDeviceSetup")] public DisposalDeviceSetup DisposalDeviceSetup { get; set; }
		[Ordinal(104)] [RED("distractionSetup")] public DistractionSetup DistractionSetup { get; set; }
		[Ordinal(105)] [RED("explosionSetup")] public DistractionSetup ExplosionSetup { get; set; }
		[Ordinal(106)] [RED("isDistractionDisabled")] public CBool IsDistractionDisabled { get; set; }
		[Ordinal(107)] [RED("wasActivated")] public CBool WasActivated { get; set; }
		[Ordinal(108)] [RED("wasLethalTakedownPerformed")] public CBool WasLethalTakedownPerformed { get; set; }
		[Ordinal(109)] [RED("isPlayerCurrentlyPerformingDisposal")] public CBool IsPlayerCurrentlyPerformingDisposal { get; set; }

		public DisposalDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
