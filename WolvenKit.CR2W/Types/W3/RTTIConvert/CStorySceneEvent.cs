using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEvent : CVariable
	{
		[RED("eventName")] 		public CString EventName { get; set;}

		[RED("startPosition")] 		public CFloat StartPosition { get; set;}

		[RED("isMuted")] 		public CBool IsMuted { get; set;}

		[RED("contexID")] 		public CInt32 ContexID { get; set;}

		[RED("sceneElement")] 		public CPtr<CStorySceneElement> SceneElement { get; set;}

		[RED("GUID")] 		public CGUID GUID { get; set;}

		[RED("interpolationEventGUID")] 		public CGUID InterpolationEventGUID { get; set;}

		[RED("blendParentGUID")] 		public CGUID BlendParentGUID { get; set;}

		[RED("linkParentGUID")] 		public CGUID LinkParentGUID { get; set;}

		[RED("linkParentTimeOffset")] 		public CFloat LinkParentTimeOffset { get; set;}

		[RED("linkChildrenGUID", 2,0)] 		public CArray<CGUID> LinkChildrenGUID { get; set;}

		[RED("trackName")] 		public CString TrackName { get; set;}

		[RED("debugString")] 		public CString DebugString { get; set;}

		public CStorySceneEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}