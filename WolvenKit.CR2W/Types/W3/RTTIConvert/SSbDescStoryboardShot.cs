using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescStoryboardShot : CVariable
	{
		[Ordinal(0)] [RED("("shotId")] 		public CString ShotId { get; set;}

		[Ordinal(0)] [RED("("infoShotname")] 		public CString InfoShotname { get; set;}

		[Ordinal(0)] [RED("("camIdChange")] 		public CString CamIdChange { get; set;}

		[Ordinal(0)] [RED("("actorPose", 2,0)] 		public CArray<SSbDescEventIdlePose> ActorPose { get; set;}

		[Ordinal(0)] [RED("("actorAnim", 2,0)] 		public CArray<SSbDescEventAnim> ActorAnim { get; set;}

		[Ordinal(0)] [RED("("actorMimic", 2,0)] 		public CArray<SSbDescEventAnim> ActorMimic { get; set;}

		[Ordinal(0)] [RED("("actorLookAt", 2,0)] 		public CArray<SSbDescEventLookAt> ActorLookAt { get; set;}

		[Ordinal(0)] [RED("("actorPlacement", 2,0)] 		public CArray<SSbDescEventPlacement> ActorPlacement { get; set;}

		[Ordinal(0)] [RED("("actorVisibility", 2,0)] 		public CArray<SSbDescEventVisibility> ActorVisibility { get; set;}

		[Ordinal(0)] [RED("("itemPlacement", 2,0)] 		public CArray<SSbDescEventPlacement> ItemPlacement { get; set;}

		[Ordinal(0)] [RED("("itemVisibility", 2,0)] 		public CArray<SSbDescEventVisibility> ItemVisibility { get; set;}

		public SSbDescStoryboardShot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSbDescStoryboardShot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}