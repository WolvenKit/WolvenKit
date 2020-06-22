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
		[RED("poseLS", 133,0)] 		public CArray<EngineQsTransform> PoseLS { get; set;}

		[RED("poseMS", 133,0)] 		public CArray<EngineQsTransform> PoseMS { get; set;}

		[RED("floatTracks", 2,0)] 		public CArray<CFloat> FloatTracks { get; set;}

		[RED("inputParamsF", 2,0)] 		public CArray<CFloat> InputParamsF { get; set;}

		[RED("inputParamsV", 2,0)] 		public CArray<Vector> InputParamsV { get; set;}

		[RED("localParamsF", 2,0)] 		public CArray<CFloat> LocalParamsF { get; set;}

		[RED("localParamsV", 2,0)] 		public CArray<Vector> LocalParamsV { get; set;}

		[RED("localParamsM", 2,0)] 		public CArray<CMatrix> LocalParamsM { get; set;}

		[RED("localParamsT", 133,0)] 		public CArray<EngineQsTransform> LocalParamsT { get; set;}

		[RED("timeDelta")] 		public CFloat TimeDelta { get; set;}

		[RED("visualDebug")] 		public CPtr<CVisualDebug> VisualDebug { get; set;}

		public SBehaviorScriptContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorScriptContext(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}