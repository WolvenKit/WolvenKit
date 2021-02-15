using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnSRRefCollection : CVariable
	{
		[Ordinal(0)] [RED("ridAnimations")] public CArray<scnRidAnimationSRRef> RidAnimations { get; set; }
		[Ordinal(1)] [RED("ridAnimSets")] public CArray<scnRidAnimSetSRRef> RidAnimSets { get; set; }
		[Ordinal(2)] [RED("ridFacialAnimSets")] public CArray<scnRidAnimSetSRRef> RidFacialAnimSets { get; set; }
		[Ordinal(3)] [RED("ridCyberwareAnimSets")] public CArray<scnRidAnimSetSRRef> RidCyberwareAnimSets { get; set; }
		[Ordinal(4)] [RED("ridDeformationAnimSets")] public CArray<scnRidAnimSetSRRef> RidDeformationAnimSets { get; set; }
		[Ordinal(5)] [RED("lipsyncAnimSets")] public CArray<scnLipsyncAnimSetSRRef> LipsyncAnimSets { get; set; }
		[Ordinal(6)] [RED("ridCameraAnimations")] public CArray<scnRidCameraAnimationSRRef> RidCameraAnimations { get; set; }
		[Ordinal(7)] [RED("cinematicAnimSets")] public CArray<scnCinematicAnimSetSRRef> CinematicAnimSets { get; set; }
		[Ordinal(8)] [RED("gameplayAnimSets")] public CArray<scnGameplayAnimSetSRRef> GameplayAnimSets { get; set; }
		[Ordinal(9)] [RED("dynamicAnimSets")] public CArray<scnDynamicAnimSetSRRef> DynamicAnimSets { get; set; }
		[Ordinal(10)] [RED("cinematicAnimNames")] public CArray<scnAnimSetAnimNames> CinematicAnimNames { get; set; }
		[Ordinal(11)] [RED("gameplayAnimNames")] public CArray<scnAnimSetAnimNames> GameplayAnimNames { get; set; }
		[Ordinal(12)] [RED("dynamicAnimNames")] public CArray<scnAnimSetDynAnimNames> DynamicAnimNames { get; set; }
		[Ordinal(13)] [RED("ridAnimationContainers")] public CArray<scnRidAnimationContainerSRRef> RidAnimationContainers { get; set; }

		public scnSRRefCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
