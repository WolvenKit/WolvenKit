using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameContainerObjectBase : gameLootContainerBase
	{
		private TweakDBID _lockedByKey;

		[Ordinal(50)] 
		[RED("lockedByKey")] 
		public TweakDBID LockedByKey
		{
			get => GetProperty(ref _lockedByKey);
			set => SetProperty(ref _lockedByKey, value);
		}
	}
}
