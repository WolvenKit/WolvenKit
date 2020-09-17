using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHeadManagerComponent : CSelfUpdatingComponent
	{
		[Ordinal(1)] [RED("timePeriod")] 		public GameTime TimePeriod { get; set;}

		[Ordinal(2)] [RED("initHeadIndex")] 		public CInt32 InitHeadIndex { get; set;}

		[Ordinal(3)] [RED("lastChangeGameTime")] 		public GameTime LastChangeGameTime { get; set;}

		[Ordinal(4)] [RED("hasTattoo")] 		public CBool HasTattoo { get; set;}

		[Ordinal(5)] [RED("hasDemonMark")] 		public CBool HasDemonMark { get; set;}

		[Ordinal(6)] [RED("curIndex")] 		public CUInt32 CurIndex { get; set;}

		[Ordinal(7)] [RED("heads", 2,0)] 		public CArray<CName> Heads { get; set;}

		[Ordinal(8)] [RED("headsWithTattoo", 2,0)] 		public CArray<CName> HeadsWithTattoo { get; set;}

		[Ordinal(9)] [RED("headsDemon", 2,0)] 		public CArray<CName> HeadsDemon { get; set;}

		[Ordinal(10)] [RED("headsDemonWithTattoo", 2,0)] 		public CArray<CName> HeadsDemonWithTattoo { get; set;}

		[Ordinal(11)] [RED("curHeadId")] 		public SItemUniqueId CurHeadId { get; set;}

		[Ordinal(12)] [RED("blockGrowing")] 		public CBool BlockGrowing { get; set;}

		public CHeadManagerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHeadManagerComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}