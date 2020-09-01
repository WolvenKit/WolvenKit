using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
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

		public CActionMoveAnimationProxy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CActionMoveAnimationProxy(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}