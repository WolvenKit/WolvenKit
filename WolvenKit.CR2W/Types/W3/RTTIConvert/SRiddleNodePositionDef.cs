using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SRiddleNodePositionDef : CVariable
	{
		[RED("animName")] 		public CName AnimName { get; set;}

		[RED("changePosTime")] 		public CFloat ChangePosTime { get; set;}

		[RED("fxName")] 		public CName FxName { get; set;}

		[RED("pairedRiddleNodes", 2,0)] 		public CArray<SPairedRiddleNodeDef> PairedRiddleNodes { get; set;}

		[RED("isPositionValid")] 		public CBool IsPositionValid { get; set;}

		[RED("externalRiddleFx")] 		public SExternalRiddleEffectEntityDef ExternalRiddleFx { get; set;}

		[RED("igni")] 		public CBool Igni { get; set;}

		[RED("aard")] 		public CBool Aard { get; set;}

		public SRiddleNodePositionDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SRiddleNodePositionDef(cr2w);

	}
}