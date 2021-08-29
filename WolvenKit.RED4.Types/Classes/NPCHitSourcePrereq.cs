using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCHitSourcePrereq : gameIScriptablePrereq
	{
		private CEnum<EAIHitSource> _hitSource;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("hitSource")] 
		public CEnum<EAIHitSource> HitSource
		{
			get => GetProperty(ref _hitSource);
			set => SetProperty(ref _hitSource, value);
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
