using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTask3StateTauntDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[RED("tauntType")] 		public CEnum<ETauntType> TauntType { get; set;}

		[RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[RED("minDuration")] 		public CFloat MinDuration { get; set;}

		[RED("maxDuration")] 		public CFloat MaxDuration { get; set;}

		public CBTTask3StateTauntDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTask3StateTauntDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}