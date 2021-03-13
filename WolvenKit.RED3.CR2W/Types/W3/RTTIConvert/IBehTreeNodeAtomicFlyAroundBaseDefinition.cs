using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IBehTreeNodeAtomicFlyAroundBaseDefinition : IBehTreeNodeAtomicFlightDefinition
	{
		[Ordinal(1)] [RED("stayInGuardArea")] 		public CBool StayInGuardArea { get; set;}

		[Ordinal(2)] [RED("distance")] 		public CBehTreeValFloat Distance { get; set;}

		[Ordinal(3)] [RED("distanceMax")] 		public CBehTreeValFloat DistanceMax { get; set;}

		[Ordinal(4)] [RED("height")] 		public CBehTreeValFloat Height { get; set;}

		[Ordinal(5)] [RED("heightMax")] 		public CBehTreeValFloat HeightMax { get; set;}

		[Ordinal(6)] [RED("randomizationDelay")] 		public CBehTreeValFloat RandomizationDelay { get; set;}

		[Ordinal(7)] [RED("pickTargetDistance")] 		public CBehTreeValFloat PickTargetDistance { get; set;}

		public IBehTreeNodeAtomicFlyAroundBaseDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new IBehTreeNodeAtomicFlyAroundBaseDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}