using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexLockRecordRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("codexRecordID")] 
		public TweakDBID CodexRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
