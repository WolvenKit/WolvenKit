using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationBufferBitwiseCompressedBoneTrack : CVariable
	{
		[Ordinal(0)] [RED("position")] 		public SAnimationBufferBitwiseCompressedData Position { get; set;}

		[Ordinal(1)] [RED("orientation")] 		public SAnimationBufferBitwiseCompressedData Orientation { get; set;}

		/// <summary>
		///  Missing in RTTI
		/// </summary>
		[Ordinal(2)] [RED("scale")] public SAnimationBufferBitwiseCompressedData Scale { get; set; }


		public SAnimationBufferBitwiseCompressedBoneTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimationBufferBitwiseCompressedBoneTrack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}