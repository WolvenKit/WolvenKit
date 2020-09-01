using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleModificatorCollision : IParticleModificator
	{
		[Ordinal(0)] [RED("("triggeringCollisionGroupNames", 2,0)] 		public CArray<CName> TriggeringCollisionGroupNames { get; set;}

		[Ordinal(0)] [RED("("dynamicFriction")] 		public CFloat DynamicFriction { get; set;}

		[Ordinal(0)] [RED("("staticFriction")] 		public CFloat StaticFriction { get; set;}

		[Ordinal(0)] [RED("("restition")] 		public CFloat Restition { get; set;}

		[Ordinal(0)] [RED("("velocityDamp")] 		public CFloat VelocityDamp { get; set;}

		[Ordinal(0)] [RED("("disableGravity")] 		public CBool DisableGravity { get; set;}

		[Ordinal(0)] [RED("("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(0)] [RED("("killWhenCollide")] 		public CBool KillWhenCollide { get; set;}

		[Ordinal(0)] [RED("("Use Gpu Simulation If Avaible")] 		public CBool Use_Gpu_Simulation_If_Avaible { get; set;}

		public CParticleModificatorCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleModificatorCollision(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}