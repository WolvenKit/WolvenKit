using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIProfile : CEntityTemplateParam
	{
		[RED("reactions", 2,0)] 		public CArray<CHandle<CAIReaction>> Reactions { get; set;}

		[RED("senseVisionParams")] 		public CPtr<CAISenseParams> SenseVisionParams { get; set;}

		[RED("senseAbsoluteParams")] 		public CPtr<CAISenseParams> SenseAbsoluteParams { get; set;}

		[RED("attitudeGroup")] 		public CName AttitudeGroup { get; set;}

		[RED("minigameParams")] 		public SAIMinigameParams MinigameParams { get; set;}

		public CAIProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIProfile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}