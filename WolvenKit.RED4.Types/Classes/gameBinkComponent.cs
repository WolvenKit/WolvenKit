using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBinkComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("meshTargetBinding")] 
		public CHandle<gameBinkMeshTargetBinding> MeshTargetBinding
		{
			get => GetPropertyValue<CHandle<gameBinkMeshTargetBinding>>();
			set => SetPropertyValue<CHandle<gameBinkMeshTargetBinding>>(value);
		}

		[Ordinal(9)] 
		[RED("videoPlayerName")] 
		public CName VideoPlayerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("binkResource")] 
		public CResourceAsyncReference<Bink> BinkResource
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(11)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("loopVideo")] 
		public CBool LoopVideo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("forceVideoFrameRate")] 
		public CBool ForceVideoFrameRate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameBinkComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			VideoPlayerName = "DefaultVideoPlayerName";
			IsEnabled = true;
		}
	}
}
