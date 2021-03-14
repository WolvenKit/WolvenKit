using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldgeometryDescriptionResult : IScriptable
	{
		[Ordinal(0)] [RED("leftHandData")] public worldgeometryHandIKDescriptionResult LeftHandData { get; set; }
		[Ordinal(1)] [RED("rightHandData")] public worldgeometryHandIKDescriptionResult RightHandData { get; set; }
		[Ordinal(2)] [RED("collisionNormal")] public Vector4 CollisionNormal { get; set; }
		[Ordinal(3)] [RED("distanceVector")] public Vector4 DistanceVector { get; set; }
		[Ordinal(4)] [RED("topPoint")] public Vector4 TopPoint { get; set; }
		[Ordinal(5)] [RED("topNormal")] public Vector4 TopNormal { get; set; }
		[Ordinal(6)] [RED("behindPoint")] public Vector4 BehindPoint { get; set; }
		[Ordinal(7)] [RED("behindNormal")] public Vector4 BehindNormal { get; set; }
		[Ordinal(8)] [RED("obstacleDepth")] public CFloat ObstacleDepth { get; set; }
		[Ordinal(9)] [RED("upExtent")] public CFloat UpExtent { get; set; }
		[Ordinal(10)] [RED("downExtent")] public CFloat DownExtent { get; set; }
		[Ordinal(11)] [RED("topExtent")] public CFloat TopExtent { get; set; }
		[Ordinal(12)] [RED("obstacleDepthStatus")] public CEnum<worldgeometryProbingStatus> ObstacleDepthStatus { get; set; }
		[Ordinal(13)] [RED("leftExtentStatus")] public CEnum<worldgeometryProbingStatus> LeftExtentStatus { get; set; }
		[Ordinal(14)] [RED("rightExtentStatus")] public CEnum<worldgeometryProbingStatus> RightExtentStatus { get; set; }
		[Ordinal(15)] [RED("upExtentStatus")] public CEnum<worldgeometryProbingStatus> UpExtentStatus { get; set; }
		[Ordinal(16)] [RED("downExtentStatus")] public CEnum<worldgeometryProbingStatus> DownExtentStatus { get; set; }
		[Ordinal(17)] [RED("topTestStatus")] public CEnum<worldgeometryProbingStatus> TopTestStatus { get; set; }
		[Ordinal(18)] [RED("behindTestStatus")] public CEnum<worldgeometryProbingStatus> BehindTestStatus { get; set; }
		[Ordinal(19)] [RED("queryStatus")] public CEnum<worldgeometryDescriptionQueryStatus> QueryStatus { get; set; }

		public worldgeometryDescriptionResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
