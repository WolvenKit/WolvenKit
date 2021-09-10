using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameContainerObjectBase : gameLootContainerBase
	{
		[Ordinal(50)] 
		[RED("lockedByKey")] 
		public TweakDBID LockedByKey
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
