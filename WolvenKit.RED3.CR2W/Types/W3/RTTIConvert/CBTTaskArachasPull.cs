using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskArachasPull : CBTTask3StateProjectileAttack
	{
		[Ordinal(1)] [RED("finishAttack")] 		public CBool FinishAttack { get; set;}

		[Ordinal(2)] [RED("m_projectilesShot")] 		public CInt32 M_projectilesShot { get; set;}

		[Ordinal(3)] [RED("m_projectilesMissed")] 		public CInt32 M_projectilesMissed { get; set;}

		public CBTTaskArachasPull(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskArachasPull(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}