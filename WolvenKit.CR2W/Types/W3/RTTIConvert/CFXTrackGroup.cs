using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackGroup : CFXBase
	{
		[RED("name")] 		public CString Name { get; set;}

		[RED("tracks", 2,0)] 		public CArray<CPtr<CFXTrack>> Tracks { get; set;}

		[RED("isExpanded")] 		public CBool IsExpanded { get; set;}

		[RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[RED("trackGroupColor")] 		public CColor TrackGroupColor { get; set;}

		[RED("componentName")] 		public CName ComponentName { get; set;}

		public CFXTrackGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXTrackGroup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}