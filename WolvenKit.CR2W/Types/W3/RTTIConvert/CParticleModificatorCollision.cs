using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleModificatorCollision : IParticleModificator
	{
		[RED("triggeringCollisionGroupNames", 2,0)] 		public CArray<CName> TriggeringCollisionGroupNames { get; set;}

		[RED("dynamicFriction")] 		public CFloat DynamicFriction { get; set;}

		[RED("staticFriction")] 		public CFloat StaticFriction { get; set;}

		[RED("restition")] 		public CFloat Restition { get; set;}

		[RED("velocityDamp")] 		public CFloat VelocityDamp { get; set;}

		[RED("disableGravity")] 		public CBool DisableGravity { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("killWhenCollide")] 		public CBool KillWhenCollide { get; set;}

		[RED("Use Gpu Simulation If Avaible")] 		public CBool Use_Gpu_Simulation_If_Avaible { get; set;}

		public CParticleModificatorCollision(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CParticleModificatorCollision(cr2w);

	}
}