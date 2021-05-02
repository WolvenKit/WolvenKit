using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CActionMoveAnimationProxy : CObject
	{
		[Ordinal(1)] [RED("isInitialized")] 		public CBool IsInitialized { get; set;}

		[Ordinal(2)] [RED("isValid")] 		public CBool IsValid { get; set;}

		[Ordinal(3)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(4)] [RED("prevTime")] 		public CFloat PrevTime { get; set;}

		[Ordinal(5)] [RED("currTime")] 		public CFloat CurrTime { get; set;}

		[Ordinal(6)] [RED("finished")] 		public CBool Finished { get; set;}

		public CActionMoveAnimationProxy(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CActionMoveAnimationProxy(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}