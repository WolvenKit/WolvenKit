using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGateEntity : W3LockableEntity
	{
		[Ordinal(1)] [RED("("currState")] 		public CName CurrState { get; set;}

		[Ordinal(2)] [RED("("speedModifier")] 		public CFloat SpeedModifier { get; set;}

		[Ordinal(3)] [RED("("initiallyOpened")] 		public CBool InitiallyOpened { get; set;}

		[Ordinal(4)] [RED("("startSound")] 		public CName StartSound { get; set;}

		[Ordinal(5)] [RED("("stopSound")] 		public CName StopSound { get; set;}

		[Ordinal(6)] [RED("("runTime")] 		public CFloat RunTime { get; set;}

		public CGateEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGateEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}