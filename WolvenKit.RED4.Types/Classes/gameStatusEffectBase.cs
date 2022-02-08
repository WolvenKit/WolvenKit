using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatusEffectBase : IScriptable
	{
		[Ordinal(0)] 
		[RED("statusEffectRecordID")] 
		public TweakDBID StatusEffectRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
