using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorScriptContext : CVariable
	{
		[Ordinal(1)] [RED("poseLS", 133,0)] 		public CArray<EngineQsTransform> PoseLS { get; set;}

		[Ordinal(2)] [RED("poseMS", 133,0)] 		public CArray<EngineQsTransform> PoseMS { get; set;}

		[Ordinal(3)] [RED("floatTracks", 2,0)] 		public CArray<CFloat> FloatTracks { get; set;}

		[Ordinal(4)] [RED("inputParamsF", 2,0)] 		public CArray<CFloat> InputParamsF { get; set;}

		[Ordinal(5)] [RED("inputParamsV", 2,0)] 		public CArray<Vector> InputParamsV { get; set;}

		[Ordinal(6)] [RED("localParamsF", 2,0)] 		public CArray<CFloat> LocalParamsF { get; set;}

		[Ordinal(7)] [RED("localParamsV", 2,0)] 		public CArray<Vector> LocalParamsV { get; set;}

		[Ordinal(8)] [RED("localParamsM", 2,0)] 		public CArray<CMatrix> LocalParamsM { get; set;}

		[Ordinal(9)] [RED("localParamsT", 133,0)] 		public CArray<EngineQsTransform> LocalParamsT { get; set;}

		[Ordinal(10)] [RED("timeDelta")] 		public CFloat TimeDelta { get; set;}

		[Ordinal(11)] [RED("visualDebug")] 		public CPtr<CVisualDebug> VisualDebug { get; set;}

		public SBehaviorScriptContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorScriptContext(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}