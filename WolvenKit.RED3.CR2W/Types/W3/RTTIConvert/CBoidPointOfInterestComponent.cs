using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBoidPointOfInterestComponent : CComponent
	{
		[Ordinal(1)] [RED("params.m_type")] 		public CName Params_m_type { get; set;}

		[Ordinal(2)] [RED("params.m_scale")] 		public CFloat Params_m_scale { get; set;}

		[Ordinal(3)] [RED("params.m_gravityRangeMin")] 		public CFloat Params_m_gravityRangeMin { get; set;}

		[Ordinal(4)] [RED("params.m_gravityRangeMax")] 		public CFloat Params_m_gravityRangeMax { get; set;}

		[Ordinal(5)] [RED("params.m_effectorRadius")] 		public CFloat Params_m_effectorRadius { get; set;}

		[Ordinal(6)] [RED("acceptor")] 		public CEnum<EZoneAcceptor> Acceptor { get; set;}

		[Ordinal(7)] [RED("params.m_shapeType")] 		public CName Params_m_shapeType { get; set;}

		[Ordinal(8)] [RED("params.m_useReachCallBack")] 		public CBool Params_m_useReachCallBack { get; set;}

		[Ordinal(9)] [RED("params.m_closestOnly")] 		public CBool Params_m_closestOnly { get; set;}

		[Ordinal(10)] [RED("params.m_coneMinOpeningAngle")] 		public CFloat Params_m_coneMinOpeningAngle { get; set;}

		[Ordinal(11)] [RED("params.m_coneMaxOpeningAngle")] 		public CFloat Params_m_coneMaxOpeningAngle { get; set;}

		[Ordinal(12)] [RED("params.m_coneEffectorOpeningAngle")] 		public CFloat Params_m_coneEffectorOpeningAngle { get; set;}

		[Ordinal(13)] [RED("crawlingSwarmDebug")] 		public CBool CrawlingSwarmDebug { get; set;}

		public CBoidPointOfInterestComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}