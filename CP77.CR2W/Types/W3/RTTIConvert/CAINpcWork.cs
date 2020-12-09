using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcWork : CAISubTree
	{
		[Ordinal(1)] [RED("actionPointSelector")] 		public CHandle<CActionPointSelector> ActionPointSelector { get; set;}

		[Ordinal(2)] [RED("spawnToWork")] 		public CBool SpawnToWork { get; set;}

		[Ordinal(3)] [RED("params")] 		public CHandle<CAINpcWorkParams> Params { get; set;}

		public CAINpcWork(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcWork(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}