using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CompletionOfFirstEquipRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("weaponID")] 
		public TweakDBID WeaponID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
