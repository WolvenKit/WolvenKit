using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCHitReactionTypePrereq : gameIScriptablePrereq
	{
		private CEnum<animHitReactionType> _hitReactionType;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("hitReactionType")] 
		public CEnum<animHitReactionType> HitReactionType
		{
			get => GetProperty(ref _hitReactionType);
			set => SetProperty(ref _hitReactionType, value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}
	}
}
