using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CharacterDataPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("idToCheck")] 
		public TweakDBID IdToCheck
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
