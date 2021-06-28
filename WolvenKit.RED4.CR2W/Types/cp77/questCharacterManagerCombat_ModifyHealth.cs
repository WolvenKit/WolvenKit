using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_ModifyHealth : questICharacterManagerCombat_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CFloat _percent;
		private CBool _setExactValue;
		private CBool _noDamageIndicator;
		private gameEntityReference _damageSourceRef;

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
		[RED("percent")] 
		public CFloat Percent
		{
			get => GetProperty(ref _percent);
			set => SetProperty(ref _percent, value);
		}

		[Ordinal(3)] 
		[RED("setExactValue")] 
		public CBool SetExactValue
		{
			get => GetProperty(ref _setExactValue);
			set => SetProperty(ref _setExactValue, value);
		}

		[Ordinal(4)] 
		[RED("noDamageIndicator")] 
		public CBool NoDamageIndicator
		{
			get => GetProperty(ref _noDamageIndicator);
			set => SetProperty(ref _noDamageIndicator, value);
		}

		[Ordinal(5)] 
		[RED("damageSourceRef")] 
		public gameEntityReference DamageSourceRef
		{
			get => GetProperty(ref _damageSourceRef);
			set => SetProperty(ref _damageSourceRef, value);
		}

		public questCharacterManagerCombat_ModifyHealth(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
