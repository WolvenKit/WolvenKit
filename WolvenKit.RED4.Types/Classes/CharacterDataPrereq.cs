using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CharacterDataPrereq : gameIScriptablePrereq
	{
		private TweakDBID _idToCheck;

		[Ordinal(0)] 
		[RED("idToCheck")] 
		public TweakDBID IdToCheck
		{
			get => GetProperty(ref _idToCheck);
			set => SetProperty(ref _idToCheck, value);
		}
	}
}
