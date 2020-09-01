using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CVitalSpot : CObject
	{
		[Ordinal(1)] [RED("editorLabel")] 		public CName EditorLabel { get; set;}

		[Ordinal(2)] [RED("entitySlotName")] 		public CName EntitySlotName { get; set;}

		[Ordinal(3)] [RED("normal")] 		public Vector Normal { get; set;}

		[Ordinal(4)] [RED("cutDirection")] 		public Vector CutDirection { get; set;}

		[Ordinal(5)] [RED("vitalSpotEntry")] 		public CHandle<CJournalPath> VitalSpotEntry { get; set;}

		[Ordinal(6)] [RED("hitReactionAnimation")] 		public CName HitReactionAnimation { get; set;}

		[Ordinal(7)] [RED("focusPointsCost")] 		public CFloat FocusPointsCost { get; set;}

		[Ordinal(8)] [RED("destroyAfterExecution")] 		public CBool DestroyAfterExecution { get; set;}

		[Ordinal(9)] [RED("gameplayEffects", 2,0)] 		public CArray<CHandle<IGameplayEffectExecutor>> GameplayEffects { get; set;}

		[Ordinal(10)] [RED("enableConditions")] 		public SVitalSpotEnableConditions EnableConditions { get; set;}

		[Ordinal(11)] [RED("visualEffect")] 		public CName VisualEffect { get; set;}

		[Ordinal(12)] [RED("soundOnFocus")] 		public CString SoundOnFocus { get; set;}

		[Ordinal(13)] [RED("soundOffFocus")] 		public CString SoundOffFocus { get; set;}

		public CVitalSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CVitalSpot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}