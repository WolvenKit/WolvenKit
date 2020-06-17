using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcReactionStopAndComment : CAINpcReaction
	{
		[RED("stopDuration")] 		public CFloat StopDuration { get; set;}

		[RED("activationChance")] 		public CInt32 ActivationChance { get; set;}

		[RED("distanceToInterrupt")] 		public CInt32 DistanceToInterrupt { get; set;}

		public CAINpcReactionStopAndComment(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAINpcReactionStopAndComment(cr2w);

	}
}