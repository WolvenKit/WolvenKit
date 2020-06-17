using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPairedRiddleNodeDef : CVariable
	{
		[RED("pairedRiddleNodeTag")] 		public CName PairedRiddleNodeTag { get; set;}

		[RED("pairedRiddleNodeRequiredPos")] 		public CInt32 PairedRiddleNodeRequiredPos { get; set;}

		[RED("externalRiddleFx")] 		public SExternalRiddleEffectEntityDef ExternalRiddleFx { get; set;}

		public SPairedRiddleNodeDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SPairedRiddleNodeDef(cr2w);

	}
}