using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTask3StateTauntDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(1)] [RED("tauntType")] 		public CEnum<ETauntType> TauntType { get; set;}

		[Ordinal(2)] [RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(3)] [RED("minDuration")] 		public CFloat MinDuration { get; set;}

		[Ordinal(4)] [RED("maxDuration")] 		public CFloat MaxDuration { get; set;}

		public CBTTask3StateTauntDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTask3StateTauntDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}