using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SRiddleNodePositionDef : CVariable
	{
		[Ordinal(1)] [RED("animName")] 		public CName AnimName { get; set;}

		[Ordinal(2)] [RED("changePosTime")] 		public CFloat ChangePosTime { get; set;}

		[Ordinal(3)] [RED("fxName")] 		public CName FxName { get; set;}

		[Ordinal(4)] [RED("pairedRiddleNodes", 2,0)] 		public CArray<SPairedRiddleNodeDef> PairedRiddleNodes { get; set;}

		[Ordinal(5)] [RED("isPositionValid")] 		public CBool IsPositionValid { get; set;}

		[Ordinal(6)] [RED("externalRiddleFx")] 		public SExternalRiddleEffectEntityDef ExternalRiddleFx { get; set;}

		[Ordinal(7)] [RED("igni")] 		public CBool Igni { get; set;}

		[Ordinal(8)] [RED("aard")] 		public CBool Aard { get; set;}

		public SRiddleNodePositionDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SRiddleNodePositionDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}