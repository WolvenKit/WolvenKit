using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FastTravelSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("fastTravelLocks")] public CArray<FastTravelSystemLock> FastTravelLocks { get; set; }
		[Ordinal(1)]  [RED("fastTravelNodes")] public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes { get; set; }
		[Ordinal(2)]  [RED("fastTravelPointsTotal")] public CInt32 FastTravelPointsTotal { get; set; }
		[Ordinal(3)]  [RED("isFastTravelEnabledOnMap")] public CBool IsFastTravelEnabledOnMap { get; set; }
		[Ordinal(4)]  [RED("loadingScreenCallbackID")] public CUInt32 LoadingScreenCallbackID { get; set; }
		[Ordinal(5)]  [RED("requestAutoSafeAfterLoadingScreen")] public CBool RequestAutoSafeAfterLoadingScreen { get; set; }

		public FastTravelSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
