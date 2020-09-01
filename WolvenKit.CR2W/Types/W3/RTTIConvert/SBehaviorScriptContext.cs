using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorScriptContext : CVariable
	{
		[Ordinal(0)] [RED("("poseLS", 133,0)] 		public CArray<EngineQsTransform> PoseLS { get; set;}

		[Ordinal(0)] [RED("("poseMS", 133,0)] 		public CArray<EngineQsTransform> PoseMS { get; set;}

		[Ordinal(0)] [RED("("floatTracks", 2,0)] 		public CArray<CFloat> FloatTracks { get; set;}

		[Ordinal(0)] [RED("("inputParamsF", 2,0)] 		public CArray<CFloat> InputParamsF { get; set;}

		[Ordinal(0)] [RED("("inputParamsV", 2,0)] 		public CArray<Vector> InputParamsV { get; set;}

		[Ordinal(0)] [RED("("localParamsF", 2,0)] 		public CArray<CFloat> LocalParamsF { get; set;}

		[Ordinal(0)] [RED("("localParamsV", 2,0)] 		public CArray<Vector> LocalParamsV { get; set;}

		[Ordinal(0)] [RED("("localParamsM", 2,0)] 		public CArray<CMatrix> LocalParamsM { get; set;}

		[Ordinal(0)] [RED("("localParamsT", 133,0)] 		public CArray<EngineQsTransform> LocalParamsT { get; set;}

		[Ordinal(0)] [RED("("timeDelta")] 		public CFloat TimeDelta { get; set;}

		[Ordinal(0)] [RED("("visualDebug")] 		public CPtr<CVisualDebug> VisualDebug { get; set;}

		public SBehaviorScriptContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorScriptContext(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}