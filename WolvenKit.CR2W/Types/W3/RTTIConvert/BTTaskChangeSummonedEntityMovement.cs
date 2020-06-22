using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskChangeSummonedEntityMovement : IBehTreeTask
	{
		[RED("speed")] 		public CFloat Speed { get; set;}

		[RED("stopDistance")] 		public CFloat StopDistance { get; set;}

		[RED("fallBackSpeed")] 		public CFloat FallBackSpeed { get; set;}

		[RED("normalSpeed")] 		public CFloat NormalSpeed { get; set;}

		[RED("verticalSpeed")] 		public CFloat VerticalSpeed { get; set;}

		[RED("speedOscilation")] 		public SRangeF SpeedOscilation { get; set;}

		[RED("normalSpeedOscilation")] 		public SRangeF NormalSpeedOscilation { get; set;}

		[RED("verticalOscilation")] 		public SRangeF VerticalOscilation { get; set;}

		[RED("speedOscilationSpeed")] 		public CFloat SpeedOscilationSpeed { get; set;}

		[RED("normalSpeedOscilationSpeed")] 		public CFloat NormalSpeedOscilationSpeed { get; set;}

		[RED("verticalOscilationSpeed")] 		public CFloat VerticalOscilationSpeed { get; set;}

		[RED("m_summonerCmp")] 		public CHandle<W3SummonerComponent> M_summonerCmp { get; set;}

		public BTTaskChangeSummonedEntityMovement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskChangeSummonedEntityMovement(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}