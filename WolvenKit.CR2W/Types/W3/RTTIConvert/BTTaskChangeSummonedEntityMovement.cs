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
		[Ordinal(1)] [RED("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(2)] [RED("stopDistance")] 		public CFloat StopDistance { get; set;}

		[Ordinal(3)] [RED("fallBackSpeed")] 		public CFloat FallBackSpeed { get; set;}

		[Ordinal(4)] [RED("normalSpeed")] 		public CFloat NormalSpeed { get; set;}

		[Ordinal(5)] [RED("verticalSpeed")] 		public CFloat VerticalSpeed { get; set;}

		[Ordinal(6)] [RED("speedOscilation")] 		public SRangeF SpeedOscilation { get; set;}

		[Ordinal(7)] [RED("normalSpeedOscilation")] 		public SRangeF NormalSpeedOscilation { get; set;}

		[Ordinal(8)] [RED("verticalOscilation")] 		public SRangeF VerticalOscilation { get; set;}

		[Ordinal(9)] [RED("speedOscilationSpeed")] 		public CFloat SpeedOscilationSpeed { get; set;}

		[Ordinal(10)] [RED("normalSpeedOscilationSpeed")] 		public CFloat NormalSpeedOscilationSpeed { get; set;}

		[Ordinal(11)] [RED("verticalOscilationSpeed")] 		public CFloat VerticalOscilationSpeed { get; set;}

		[Ordinal(12)] [RED("m_summonerCmp")] 		public CHandle<W3SummonerComponent> M_summonerCmp { get; set;}

		public BTTaskChangeSummonedEntityMovement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskChangeSummonedEntityMovement(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}