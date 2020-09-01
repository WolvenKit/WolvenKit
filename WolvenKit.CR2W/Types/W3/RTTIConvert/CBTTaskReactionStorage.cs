using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskReactionStorage : IBehTreeTask
	{
		[Ordinal(1)] [RED("reactionDataStorage")] 		public CHandle<CAIStorageReactionData> ReactionDataStorage { get; set;}

		[Ordinal(2)] [RED("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(3)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(4)] [RED("onCompletion")] 		public CBool OnCompletion { get; set;}

		[Ordinal(5)] [RED("setIsAlarmed")] 		public CBool SetIsAlarmed { get; set;}

		[Ordinal(6)] [RED("setTaunted")] 		public CBool SetTaunted { get; set;}

		[Ordinal(7)] [RED("reset")] 		public CBool Reset { get; set;}

		public CBTTaskReactionStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskReactionStorage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}