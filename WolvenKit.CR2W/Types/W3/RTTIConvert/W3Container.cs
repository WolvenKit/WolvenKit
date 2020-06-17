using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Container : W3LockableEntity
	{
		[RED("shouldBeFullySaved")] 		public CBool ShouldBeFullySaved { get; set;}

		[RED("isDynamic")] 		public CBool IsDynamic { get; set;}

		[RED("skipInventoryPanel")] 		public CBool SkipInventoryPanel { get; set;}

		[RED("focusModeHighlight")] 		public EFocusModeVisibility FocusModeHighlight { get; set;}

		[RED("factOnContainerOpened")] 		public CString FactOnContainerOpened { get; set;}

		[RED("allowToInjectBalanceItems")] 		public CBool AllowToInjectBalanceItems { get; set;}

		[RED("disableLooting")] 		public CBool DisableLooting { get; set;}

		[RED("disableStealing")] 		public CBool DisableStealing { get; set;}

		[RED("mergeNotification")] 		public CBool MergeNotification { get; set;}

		public W3Container(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3Container(cr2w);

	}
}