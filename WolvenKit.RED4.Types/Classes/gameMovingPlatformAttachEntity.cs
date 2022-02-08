using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMovingPlatformAttachEntity : redEvent
	{
		[Ordinal(0)] 
		[RED("entity")] 
		public CWeakHandle<entEntity> Entity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}
	}
}
