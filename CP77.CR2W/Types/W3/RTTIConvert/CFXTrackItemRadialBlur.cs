using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemRadialBlur : CFXTrackItemCurveBase
	{
		[Ordinal(1)] [RED("trackComponentPosition")] 		public CBool TrackComponentPosition { get; set;}

		[Ordinal(2)] [RED("distanceFromCamera")] 		public CFloat DistanceFromCamera { get; set;}

		[Ordinal(3)] [RED("centerMultiplier")] 		public CFloat CenterMultiplier { get; set;}

		public CFXTrackItemRadialBlur(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXTrackItemRadialBlur(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}