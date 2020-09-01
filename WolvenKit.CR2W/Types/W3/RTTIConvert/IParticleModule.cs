using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IParticleModule : CObject
	{
		[Ordinal(1)] [RED("("editorName")] 		public CString EditorName { get; set;}

		[Ordinal(2)] [RED("("editorColor")] 		public CColor EditorColor { get; set;}

		[Ordinal(3)] [RED("("editorGroup")] 		public CString EditorGroup { get; set;}

		[Ordinal(4)] [RED("("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(5)] [RED("("isShowing")] 		public CBool IsShowing { get; set;}

		[Ordinal(6)] [RED("("isSelected")] 		public CBool IsSelected { get; set;}

		public IParticleModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new IParticleModule(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}