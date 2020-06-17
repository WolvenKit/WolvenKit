using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemRadialBlur : CFXTrackItemCurveBase
	{
		[RED("trackComponentPosition")] 		public CBool TrackComponentPosition { get; set;}

		[RED("distanceFromCamera")] 		public CFloat DistanceFromCamera { get; set;}

		[RED("centerMultiplier")] 		public CFloat CenterMultiplier { get; set;}

		public CFXTrackItemRadialBlur(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CFXTrackItemRadialBlur(cr2w);

	}
}