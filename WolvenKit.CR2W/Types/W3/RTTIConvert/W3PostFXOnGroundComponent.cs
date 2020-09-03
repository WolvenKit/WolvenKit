using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PostFXOnGroundComponent : CSelfUpdatingComponent
	{
		[Ordinal(1)] [RED("fadeInTime")] 		public CFloat FadeInTime { get; set;}

		[Ordinal(2)] [RED("activeTime")] 		public CFloat ActiveTime { get; set;}

		[Ordinal(3)] [RED("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[Ordinal(4)] [RED("range")] 		public CFloat Range { get; set;}

		[Ordinal(5)] [RED("type")] 		public CInt32 Type { get; set;}

		[Ordinal(6)] [RED("updateDelay")] 		public CFloat UpdateDelay { get; set;}

		[Ordinal(7)] [RED("stopAtDeath")] 		public CBool StopAtDeath { get; set;}

		[Ordinal(8)] [RED("m_Actor")] 		public CHandle<CActor> M_Actor { get; set;}

		[Ordinal(9)] [RED("m_DelaySinceLastUpdate")] 		public CFloat M_DelaySinceLastUpdate { get; set;}

		[Ordinal(10)] [RED("m_DefaultFadeInTime")] 		public CFloat M_DefaultFadeInTime { get; set;}

		[Ordinal(11)] [RED("m_DefaultActiveTime")] 		public CFloat M_DefaultActiveTime { get; set;}

		[Ordinal(12)] [RED("m_DefaultFadeOutTime")] 		public CFloat M_DefaultFadeOutTime { get; set;}

		[Ordinal(13)] [RED("m_DefaultRange")] 		public CFloat M_DefaultRange { get; set;}

		public W3PostFXOnGroundComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PostFXOnGroundComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}