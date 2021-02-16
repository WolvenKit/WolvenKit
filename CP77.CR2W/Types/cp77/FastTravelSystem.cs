using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FastTravelSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("fastTravelNodes")] public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes { get; set; }
		[Ordinal(1)] [RED("isFastTravelEnabledOnMap")] public CBool IsFastTravelEnabledOnMap { get; set; }
		[Ordinal(2)] [RED("fastTravelPointsTotal")] public CInt32 FastTravelPointsTotal { get; set; }
		[Ordinal(3)] [RED("fastTravelLocks")] public CArray<FastTravelSystemLock> FastTravelLocks { get; set; }
		[Ordinal(4)] [RED("loadingScreenCallbackID")] public CUInt32 LoadingScreenCallbackID { get; set; }
		[Ordinal(5)] [RED("requestAutoSafeAfterLoadingScreen")] public CBool RequestAutoSafeAfterLoadingScreen { get; set; }

		public FastTravelSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
