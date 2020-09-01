using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TCrDefinition : CObject
	{
		[Ordinal(0)] [RED("("root")] 		public CName Root { get; set;}

		[Ordinal(0)] [RED("("indexRoot")] 		public CInt32 IndexRoot { get; set;}

		[Ordinal(0)] [RED("("pelvis")] 		public CName Pelvis { get; set;}

		[Ordinal(0)] [RED("("indexPelvis")] 		public CInt32 IndexPelvis { get; set;}

		[Ordinal(0)] [RED("("torso1")] 		public CName Torso1 { get; set;}

		[Ordinal(0)] [RED("("indexTorso1")] 		public CInt32 IndexTorso1 { get; set;}

		[Ordinal(0)] [RED("("torso2")] 		public CName Torso2 { get; set;}

		[Ordinal(0)] [RED("("indexTorso2")] 		public CInt32 IndexTorso2 { get; set;}

		[Ordinal(0)] [RED("("torso3")] 		public CName Torso3 { get; set;}

		[Ordinal(0)] [RED("("indexTorso3")] 		public CInt32 IndexTorso3 { get; set;}

		[Ordinal(0)] [RED("("neck")] 		public CName Neck { get; set;}

		[Ordinal(0)] [RED("("indexNeck")] 		public CInt32 IndexNeck { get; set;}

		[Ordinal(0)] [RED("("head")] 		public CName Head { get; set;}

		[Ordinal(0)] [RED("("indexHead")] 		public CInt32 IndexHead { get; set;}

		[Ordinal(0)] [RED("("shoulderL")] 		public CName ShoulderL { get; set;}

		[Ordinal(0)] [RED("("indexShoulderL")] 		public CInt32 IndexShoulderL { get; set;}

		[Ordinal(0)] [RED("("bicepL")] 		public CName BicepL { get; set;}

		[Ordinal(0)] [RED("("indexBicepL")] 		public CInt32 IndexBicepL { get; set;}

		[Ordinal(0)] [RED("("forearmL")] 		public CName ForearmL { get; set;}

		[Ordinal(0)] [RED("("indexForearmL")] 		public CInt32 IndexForearmL { get; set;}

		[Ordinal(0)] [RED("("handL")] 		public CName HandL { get; set;}

		[Ordinal(0)] [RED("("indexHandL")] 		public CInt32 IndexHandL { get; set;}

		[Ordinal(0)] [RED("("weaponL")] 		public CName WeaponL { get; set;}

		[Ordinal(0)] [RED("("indexWeaponL")] 		public CInt32 IndexWeaponL { get; set;}

		[Ordinal(0)] [RED("("shoulderR")] 		public CName ShoulderR { get; set;}

		[Ordinal(0)] [RED("("indexShoulderR")] 		public CInt32 IndexShoulderR { get; set;}

		[Ordinal(0)] [RED("("bicepR")] 		public CName BicepR { get; set;}

		[Ordinal(0)] [RED("("indexBicepR")] 		public CInt32 IndexBicepR { get; set;}

		[Ordinal(0)] [RED("("forearmR")] 		public CName ForearmR { get; set;}

		[Ordinal(0)] [RED("("indexForearmR")] 		public CInt32 IndexForearmR { get; set;}

		[Ordinal(0)] [RED("("handR")] 		public CName HandR { get; set;}

		[Ordinal(0)] [RED("("indexHandR")] 		public CInt32 IndexHandR { get; set;}

		[Ordinal(0)] [RED("("weaponR")] 		public CName WeaponR { get; set;}

		[Ordinal(0)] [RED("("indexWeaponR")] 		public CInt32 IndexWeaponR { get; set;}

		[Ordinal(0)] [RED("("thighL")] 		public CName ThighL { get; set;}

		[Ordinal(0)] [RED("("indexThighL")] 		public CInt32 IndexThighL { get; set;}

		[Ordinal(0)] [RED("("shinL")] 		public CName ShinL { get; set;}

		[Ordinal(0)] [RED("("indexShinL")] 		public CInt32 IndexShinL { get; set;}

		[Ordinal(0)] [RED("("footL")] 		public CName FootL { get; set;}

		[Ordinal(0)] [RED("("indexFootL")] 		public CInt32 IndexFootL { get; set;}

		[Ordinal(0)] [RED("("toeL")] 		public CName ToeL { get; set;}

		[Ordinal(0)] [RED("("indexToeL")] 		public CInt32 IndexToeL { get; set;}

		[Ordinal(0)] [RED("("thighR")] 		public CName ThighR { get; set;}

		[Ordinal(0)] [RED("("indexThighR")] 		public CInt32 IndexThighR { get; set;}

		[Ordinal(0)] [RED("("shinR")] 		public CName ShinR { get; set;}

		[Ordinal(0)] [RED("("indexShinR")] 		public CInt32 IndexShinR { get; set;}

		[Ordinal(0)] [RED("("footR")] 		public CName FootR { get; set;}

		[Ordinal(0)] [RED("("indexFootR")] 		public CInt32 IndexFootR { get; set;}

		[Ordinal(0)] [RED("("toeR")] 		public CName ToeR { get; set;}

		[Ordinal(0)] [RED("("indexToeR")] 		public CInt32 IndexToeR { get; set;}

		[Ordinal(0)] [RED("("pelvisUpDir")] 		public CEnum<EAxis> PelvisUpDir { get; set;}

		[Ordinal(0)] [RED("("torso1UpDir")] 		public CEnum<EAxis> Torso1UpDir { get; set;}

		[Ordinal(0)] [RED("("torso2UpDir")] 		public CEnum<EAxis> Torso2UpDir { get; set;}

		[Ordinal(0)] [RED("("torso3UpDir")] 		public CEnum<EAxis> Torso3UpDir { get; set;}

		public TCrDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new TCrDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}