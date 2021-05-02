using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3FoodComponent : W3ScentComponent
	{
		[Ordinal(1)] [RED("maxEater")] 		public CInt32 MaxEater { get; set;}

		[Ordinal(2)] [RED("distanceToEat")] 		public CFloat DistanceToEat { get; set;}

		[Ordinal(3)] [RED("startAngleToEat")] 		public CFloat StartAngleToEat { get; set;}

		[Ordinal(4)] [RED("arcWidthToEat")] 		public CFloat ArcWidthToEat { get; set;}

		[Ordinal(5)] [RED("m_Eaters", 2,0)] 		public CArray<CHandle<CActor>> M_Eaters { get; set;}

		[Ordinal(6)] [RED("m_LockDistance")] 		public CFloat M_LockDistance { get; set;}

		[Ordinal(7)] [RED("m_EatSlots", 2,0)] 		public CArray<Vector> M_EatSlots { get; set;}

		[Ordinal(8)] [RED("m_LastTimeEaten")] 		public CFloat M_LastTimeEaten { get; set;}

		public W3FoodComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3FoodComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}