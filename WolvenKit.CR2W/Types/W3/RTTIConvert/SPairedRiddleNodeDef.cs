using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SPairedRiddleNodeDef : CVariable
	{
		[Ordinal(0)] [RED("("pairedRiddleNodeTag")] 		public CName PairedRiddleNodeTag { get; set;}

		[Ordinal(0)] [RED("("pairedRiddleNodeRequiredPos")] 		public CInt32 PairedRiddleNodeRequiredPos { get; set;}

		[Ordinal(0)] [RED("("externalRiddleFx")] 		public SExternalRiddleEffectEntityDef ExternalRiddleFx { get; set;}

		public SPairedRiddleNodeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SPairedRiddleNodeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}