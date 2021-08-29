using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerCombat_ChangeLevel : questICharacterManagerCombat_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private questInt32ValueWrapper _level;
		private CBool _setExactLevel;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("level")] 
		public questInt32ValueWrapper Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(2)] 
		[RED("setExactLevel")] 
		public CBool SetExactLevel
		{
			get => GetProperty(ref _setExactLevel);
			set => SetProperty(ref _setExactLevel, value);
		}
	}
}
