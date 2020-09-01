using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MapInitData : W3MenuInitData
	{
		[Ordinal(1)] [RED("m_triggeredExitEntity")] 		public CBool M_triggeredExitEntity { get; set;}

		[Ordinal(2)] [RED("m_usedFastTravelEntity")] 		public CHandle<CEntity> M_usedFastTravelEntity { get; set;}

		[Ordinal(3)] [RED("m_isSailing")] 		public CBool M_isSailing { get; set;}

		public W3MapInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MapInitData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}