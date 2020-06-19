using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TCrDefinition : CObject
	{
		[RED("root")] 		public CName Root { get; set;}

		[RED("indexRoot")] 		public CInt32 IndexRoot { get; set;}

		[RED("pelvis")] 		public CName Pelvis { get; set;}

		[RED("indexPelvis")] 		public CInt32 IndexPelvis { get; set;}

		[RED("torso1")] 		public CName Torso1 { get; set;}

		[RED("indexTorso1")] 		public CInt32 IndexTorso1 { get; set;}

		[RED("torso2")] 		public CName Torso2 { get; set;}

		[RED("indexTorso2")] 		public CInt32 IndexTorso2 { get; set;}

		[RED("torso3")] 		public CName Torso3 { get; set;}

		[RED("indexTorso3")] 		public CInt32 IndexTorso3 { get; set;}

		[RED("neck")] 		public CName Neck { get; set;}

		[RED("indexNeck")] 		public CInt32 IndexNeck { get; set;}

		[RED("head")] 		public CName Head { get; set;}

		[RED("indexHead")] 		public CInt32 IndexHead { get; set;}

		[RED("shoulderL")] 		public CName ShoulderL { get; set;}

		[RED("indexShoulderL")] 		public CInt32 IndexShoulderL { get; set;}

		[RED("bicepL")] 		public CName BicepL { get; set;}

		[RED("indexBicepL")] 		public CInt32 IndexBicepL { get; set;}

		[RED("forearmL")] 		public CName ForearmL { get; set;}

		[RED("indexForearmL")] 		public CInt32 IndexForearmL { get; set;}

		[RED("handL")] 		public CName HandL { get; set;}

		[RED("indexHandL")] 		public CInt32 IndexHandL { get; set;}

		[RED("weaponL")] 		public CName WeaponL { get; set;}

		[RED("indexWeaponL")] 		public CInt32 IndexWeaponL { get; set;}

		[RED("shoulderR")] 		public CName ShoulderR { get; set;}

		[RED("indexShoulderR")] 		public CInt32 IndexShoulderR { get; set;}

		[RED("bicepR")] 		public CName BicepR { get; set;}

		[RED("indexBicepR")] 		public CInt32 IndexBicepR { get; set;}

		[RED("forearmR")] 		public CName ForearmR { get; set;}

		[RED("indexForearmR")] 		public CInt32 IndexForearmR { get; set;}

		[RED("handR")] 		public CName HandR { get; set;}

		[RED("indexHandR")] 		public CInt32 IndexHandR { get; set;}

		[RED("weaponR")] 		public CName WeaponR { get; set;}

		[RED("indexWeaponR")] 		public CInt32 IndexWeaponR { get; set;}

		[RED("thighL")] 		public CName ThighL { get; set;}

		[RED("indexThighL")] 		public CInt32 IndexThighL { get; set;}

		[RED("shinL")] 		public CName ShinL { get; set;}

		[RED("indexShinL")] 		public CInt32 IndexShinL { get; set;}

		[RED("footL")] 		public CName FootL { get; set;}

		[RED("indexFootL")] 		public CInt32 IndexFootL { get; set;}

		[RED("toeL")] 		public CName ToeL { get; set;}

		[RED("indexToeL")] 		public CInt32 IndexToeL { get; set;}

		[RED("thighR")] 		public CName ThighR { get; set;}

		[RED("indexThighR")] 		public CInt32 IndexThighR { get; set;}

		[RED("shinR")] 		public CName ShinR { get; set;}

		[RED("indexShinR")] 		public CInt32 IndexShinR { get; set;}

		[RED("footR")] 		public CName FootR { get; set;}

		[RED("indexFootR")] 		public CInt32 IndexFootR { get; set;}

		[RED("toeR")] 		public CName ToeR { get; set;}

		[RED("indexToeR")] 		public CInt32 IndexToeR { get; set;}

		[RED("pelvisUpDir")] 		public CEnum<EAxis> PelvisUpDir { get; set;}

		[RED("torso1UpDir")] 		public CEnum<EAxis> Torso1UpDir { get; set;}

		[RED("torso2UpDir")] 		public CEnum<EAxis> Torso2UpDir { get; set;}

		[RED("torso3UpDir")] 		public CEnum<EAxis> Torso3UpDir { get; set;}

		public TCrDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new TCrDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}