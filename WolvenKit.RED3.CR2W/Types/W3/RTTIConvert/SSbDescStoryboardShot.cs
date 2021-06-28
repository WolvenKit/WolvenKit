using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescStoryboardShot : CVariable
	{
		[Ordinal(1)] [RED("shotId")] 		public CString ShotId { get; set;}

		[Ordinal(2)] [RED("infoShotname")] 		public CString InfoShotname { get; set;}

		[Ordinal(3)] [RED("camIdChange")] 		public CString CamIdChange { get; set;}

		[Ordinal(4)] [RED("actorPose", 2,0)] 		public CArray<SSbDescEventIdlePose> ActorPose { get; set;}

		[Ordinal(5)] [RED("actorAnim", 2,0)] 		public CArray<SSbDescEventAnim> ActorAnim { get; set;}

		[Ordinal(6)] [RED("actorMimic", 2,0)] 		public CArray<SSbDescEventAnim> ActorMimic { get; set;}

		[Ordinal(7)] [RED("actorLookAt", 2,0)] 		public CArray<SSbDescEventLookAt> ActorLookAt { get; set;}

		[Ordinal(8)] [RED("actorPlacement", 2,0)] 		public CArray<SSbDescEventPlacement> ActorPlacement { get; set;}

		[Ordinal(9)] [RED("actorVisibility", 2,0)] 		public CArray<SSbDescEventVisibility> ActorVisibility { get; set;}

		[Ordinal(10)] [RED("itemPlacement", 2,0)] 		public CArray<SSbDescEventPlacement> ItemPlacement { get; set;}

		[Ordinal(11)] [RED("itemVisibility", 2,0)] 		public CArray<SSbDescEventVisibility> ItemVisibility { get; set;}

		public SSbDescStoryboardShot(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}