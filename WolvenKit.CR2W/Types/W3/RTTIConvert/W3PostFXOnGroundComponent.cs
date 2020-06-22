using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PostFXOnGroundComponent : CSelfUpdatingComponent
	{
		[RED("fadeInTime")] 		public CFloat FadeInTime { get; set;}

		[RED("activeTime")] 		public CFloat ActiveTime { get; set;}

		[RED("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[RED("range")] 		public CFloat Range { get; set;}

		[RED("type")] 		public CInt32 Type { get; set;}

		[RED("updateDelay")] 		public CFloat UpdateDelay { get; set;}

		[RED("stopAtDeath")] 		public CBool StopAtDeath { get; set;}

		[RED("m_Actor")] 		public CHandle<CActor> M_Actor { get; set;}

		[RED("m_DelaySinceLastUpdate")] 		public CFloat M_DelaySinceLastUpdate { get; set;}

		[RED("m_DefaultFadeInTime")] 		public CFloat M_DefaultFadeInTime { get; set;}

		[RED("m_DefaultActiveTime")] 		public CFloat M_DefaultActiveTime { get; set;}

		[RED("m_DefaultFadeOutTime")] 		public CFloat M_DefaultFadeOutTime { get; set;}

		[RED("m_DefaultRange")] 		public CFloat M_DefaultRange { get; set;}

		public W3PostFXOnGroundComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PostFXOnGroundComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}