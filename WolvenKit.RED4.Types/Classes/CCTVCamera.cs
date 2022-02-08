using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CCTVCamera : gameObject
	{
		[Ordinal(40)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(41)] 
		[RED("camera")] 
		public CHandle<gameCameraComponent> Camera
		{
			get => GetPropertyValue<CHandle<gameCameraComponent>>();
			set => SetPropertyValue<CHandle<gameCameraComponent>>(value);
		}

		[Ordinal(42)] 
		[RED("isControlled")] 
		public CBool IsControlled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("cachedPuppetID")] 
		public entEntityID CachedPuppetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public CCTVCamera()
		{
			CachedPuppetID = new();
		}
	}
}
