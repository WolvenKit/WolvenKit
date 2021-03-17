using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_ChangeLevel : questICharacterManagerCombat_NodeSubType
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

		public questCharacterManagerCombat_ChangeLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
