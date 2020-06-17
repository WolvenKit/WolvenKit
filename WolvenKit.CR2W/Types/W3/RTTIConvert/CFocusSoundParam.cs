using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFocusSoundParam : CGameplayEntityParam
	{
		[RED("eventStart")] 		public CName EventStart { get; set;}

		[RED("eventStop")] 		public CName EventStop { get; set;}

		[RED("hearingAngle")] 		public CFloat HearingAngle { get; set;}

		[RED("visualEffectBoneName")] 		public CName VisualEffectBoneName { get; set;}

		public CFocusSoundParam(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CFocusSoundParam(cr2w);

	}
}