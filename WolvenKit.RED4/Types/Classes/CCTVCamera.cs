using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CCTVCamera : gameObject
	{
		[Ordinal(36)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(37)] 
		[RED("camera")] 
		public CHandle<gameCameraComponent> Camera
		{
			get => GetPropertyValue<CHandle<gameCameraComponent>>();
			set => SetPropertyValue<CHandle<gameCameraComponent>>(value);
		}

		[Ordinal(38)] 
		[RED("isControlled")] 
		public CBool IsControlled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("cachedPuppetID")] 
		public entEntityID CachedPuppetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public CCTVCamera()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
