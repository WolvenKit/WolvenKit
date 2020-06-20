using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationMover : CObject
	{
		[RED("m_SlideMaxSpeedSafeF")] 		public CFloat M_SlideMaxSpeedSafeF { get; set;}

		[RED("m_SlideMaxSpeedToFallF")] 		public CFloat M_SlideMaxSpeedToFallF { get; set;}

		[RED("gravityCurve")] 		public CHandle<CCurve> GravityCurve { get; set;}

		public CExplorationMover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationMover(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}