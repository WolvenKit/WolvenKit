using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questIAudioCharacterManager_NodeSubTypeCharacterEntry : CVariable
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _enableSubSystem;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("enableSubSystem")] 
		public CBool EnableSubSystem
		{
			get => GetProperty(ref _enableSubSystem);
			set => SetProperty(ref _enableSubSystem, value);
		}

		public questIAudioCharacterManager_NodeSubTypeCharacterEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
