using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Elevator : CGameplayEntity
	{
		[RED("appearanceOnTop")] 		public CString AppearanceOnTop { get; set;}

		[RED("appearanceOnGround")] 		public CString AppearanceOnGround { get; set;}

		[RED("speed")] 		public CFloat Speed { get; set;}

		[RED("currentHeight")] 		public CFloat CurrentHeight { get; set;}

		[RED("targetNodeHeight")] 		public CFloat TargetNodeHeight { get; set;}

		[RED("currentSpeed")] 		public CFloat CurrentSpeed { get; set;}

		[RED("initialSpeed")] 		public CFloat InitialSpeed { get; set;}

		[RED("isOnTop")] 		public CBool IsOnTop { get; set;}

		[RED("movementStarted")] 		public CBool MovementStarted { get; set;}

		[RED("onTopPosChecked")] 		public CBool OnTopPosChecked { get; set;}

		[RED("initialHeight")] 		public CFloat InitialHeight { get; set;}

		[RED("pos")] 		public Vector Pos { get; set;}

		[RED("onTopPos")] 		public Vector OnTopPos { get; set;}

		[RED("heightDifference")] 		public CFloat HeightDifference { get; set;}

		[RED("goingUp")] 		public CBool GoingUp { get; set;}

		[RED("playerOnElevator")] 		public CBool PlayerOnElevator { get; set;}

		[RED("playerAttached")] 		public CBool PlayerAttached { get; set;}

		[RED("deniedAreaCreated")] 		public CBool DeniedAreaCreated { get; set;}

		[RED("blockedActions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> BlockedActions { get; set;}

		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("deniedArea1")] 		public CHandle<CEntity> DeniedArea1 { get; set;}

		[RED("deniedArea2")] 		public CHandle<CEntity> DeniedArea2 { get; set;}

		[RED("deniedArea3")] 		public CHandle<CEntity> DeniedArea3 { get; set;}

		public W3Elevator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Elevator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}