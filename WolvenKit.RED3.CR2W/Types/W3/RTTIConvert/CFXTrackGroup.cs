using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackGroup : CFXBase
	{
		[Ordinal(1)] [RED("name")] 		public CString Name { get; set;}

		[Ordinal(2)] [RED("tracks", 2,0)] 		public CArray<CPtr<CFXTrack>> Tracks { get; set;}

		[Ordinal(3)] [RED("isExpanded")] 		public CBool IsExpanded { get; set;}

		[Ordinal(4)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(5)] [RED("trackGroupColor")] 		public CColor TrackGroupColor { get; set;}

		[Ordinal(6)] [RED("componentName")] 		public CName ComponentName { get; set;}

		public CFXTrackGroup(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXTrackGroup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}