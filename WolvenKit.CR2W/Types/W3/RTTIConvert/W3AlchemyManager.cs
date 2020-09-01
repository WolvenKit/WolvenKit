using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3AlchemyManager : CObject
	{
		[Ordinal(1)] [RED("("recipes", 2,0)] 		public CArray<SAlchemyRecipe> Recipes { get; set;}

		[Ordinal(2)] [RED("("isPlayerMounted")] 		public CBool IsPlayerMounted { get; set;}

		[Ordinal(3)] [RED("("isPlayerInCombat")] 		public CBool IsPlayerInCombat { get; set;}

		public W3AlchemyManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3AlchemyManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}