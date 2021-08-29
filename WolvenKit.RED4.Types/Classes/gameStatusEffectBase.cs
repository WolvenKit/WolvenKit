using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatusEffectBase : IScriptable
	{
		private TweakDBID _statusEffectRecordID;

		[Ordinal(0)] 
		[RED("statusEffectRecordID")] 
		public TweakDBID StatusEffectRecordID
		{
			get => GetProperty(ref _statusEffectRecordID);
			set => SetProperty(ref _statusEffectRecordID, value);
		}
	}
}
