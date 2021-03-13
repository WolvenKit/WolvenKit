using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CGameWorld : CWorld
	{
		[Ordinal(1)] [RED("cookedExplorations")] 		public CHandle<CCookedExplorations> CookedExplorations { get; set;}

		[Ordinal(2)] [RED("cookedWaypoints")] 		public CHandle<CWayPointsCollectionsSet> CookedWaypoints { get; set;}

		public CGameWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGameWorld(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}