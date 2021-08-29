using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimation_SpawnEffect : gameTransformAnimation_Effects
	{
		private CName _effectName;
		private CName _effectTag;
		private CBool _persistOnDetach;

		[Ordinal(0)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		[Ordinal(1)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetProperty(ref _effectTag);
			set => SetProperty(ref _effectTag, value);
		}

		[Ordinal(2)] 
		[RED("persistOnDetach")] 
		public CBool PersistOnDetach
		{
			get => GetProperty(ref _persistOnDetach);
			set => SetProperty(ref _persistOnDetach, value);
		}
	}
}
