using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisBluelinePart : IScriptable
	{
		private CBool _passed;
		private TweakDBID _captionIconRecordId;

		[Ordinal(0)] 
		[RED("passed")] 
		public CBool Passed
		{
			get => GetProperty(ref _passed);
			set => SetProperty(ref _passed, value);
		}

		[Ordinal(1)] 
		[RED("captionIconRecordId")] 
		public TweakDBID CaptionIconRecordId
		{
			get => GetProperty(ref _captionIconRecordId);
			set => SetProperty(ref _captionIconRecordId, value);
		}

		public gameinteractionsvisBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
