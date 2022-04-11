using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsvisBluelinePart : IScriptable
	{
		[Ordinal(0)] 
		[RED("passed")] 
		public CBool Passed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("captionIconRecordId")] 
		public TweakDBID CaptionIconRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
