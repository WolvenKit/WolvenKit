using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IBehTreeNodeAtomicFlyAroundBaseDefinition : IBehTreeNodeAtomicFlightDefinition
	{
		[RED("stayInGuardArea")] 		public CBool StayInGuardArea { get; set;}

		[RED("distance")] 		public CBehTreeValFloat Distance { get; set;}

		[RED("distanceMax")] 		public CBehTreeValFloat DistanceMax { get; set;}

		[RED("height")] 		public CBehTreeValFloat Height { get; set;}

		[RED("heightMax")] 		public CBehTreeValFloat HeightMax { get; set;}

		[RED("randomizationDelay")] 		public CBehTreeValFloat RandomizationDelay { get; set;}

		[RED("pickTargetDistance")] 		public CBehTreeValFloat PickTargetDistance { get; set;}

		public IBehTreeNodeAtomicFlyAroundBaseDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new IBehTreeNodeAtomicFlyAroundBaseDefinition(cr2w);

	}
}