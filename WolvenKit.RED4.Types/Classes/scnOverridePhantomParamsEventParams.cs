using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnOverridePhantomParamsEventParams : RedBaseClass
	{
		private scnPerformerId _performer;
		private CName _overrideSpawnEffect;
		private CName _overrideIdleEffect;

		[Ordinal(0)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetProperty(ref _performer);
			set => SetProperty(ref _performer, value);
		}

		[Ordinal(1)] 
		[RED("overrideSpawnEffect")] 
		public CName OverrideSpawnEffect
		{
			get => GetProperty(ref _overrideSpawnEffect);
			set => SetProperty(ref _overrideSpawnEffect, value);
		}

		[Ordinal(2)] 
		[RED("overrideIdleEffect")] 
		public CName OverrideIdleEffect
		{
			get => GetProperty(ref _overrideIdleEffect);
			set => SetProperty(ref _overrideIdleEffect, value);
		}
	}
}
