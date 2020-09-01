using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskChangeStanceDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("newStance")] 		public CEnum<ENpcStance> NewStance { get; set;}

		[Ordinal(0)] [RED("("setPrevStanceOnDeactivation")] 		public CBool SetPrevStanceOnDeactivation { get; set;}

		[Ordinal(0)] [RED("("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(0)] [RED("("changeToFlyOnlyIfAboveGround")] 		public CBool ChangeToFlyOnlyIfAboveGround { get; set;}

		public CBTTaskChangeStanceDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskChangeStanceDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}