using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSendInfo : IBehTreeTask
	{
		[Ordinal(1)] [RED("onIsAvailable")] 		public CBool OnIsAvailable { get; set;}

		[Ordinal(2)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(3)] [RED("onDectivate")] 		public CBool OnDectivate { get; set;}

		[Ordinal(4)] [RED("infoType")] 		public CEnum<EActionInfoType> InfoType { get; set;}

		[Ordinal(5)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(6)] [RED("distanceToBecomeUnawareOfOldTarget")] 		public CFloat DistanceToBecomeUnawareOfOldTarget { get; set;}

		[Ordinal(7)] [RED("lastTarget")] 		public CHandle<CNode> LastTarget { get; set;}

		public CBTTaskSendInfo(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}