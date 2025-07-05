using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeTankPlayerController : gameuiarcadeArcadePlayerController
	{
		[Ordinal(2)] 
		[RED("avatarRef")] 
		public inkWidgetReference AvatarRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("health")] 
		public inkWidgetReference Health
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("lives")] 
		public inkWidgetReference Lives
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("aeams")] 
		public inkWidgetReference Aeams
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("projectileSpawner")] 
		public inkWidgetReference ProjectileSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeTankPlayerController()
		{
			ColliderList = new();
			AvatarRef = new inkWidgetReference();
			Health = new inkWidgetReference();
			Lives = new inkWidgetReference();
			Aeams = new inkWidgetReference();
			ProjectileSpawner = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
