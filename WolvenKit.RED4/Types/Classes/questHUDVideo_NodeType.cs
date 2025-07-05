using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questHUDVideo_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("video")] 
		public CResourceAsyncReference<Bink> Video
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(1)] 
		[RED("skippable")] 
		public CBool Skippable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("syncToAudio")] 
		public CBool SyncToAudio
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("retriggerAudioOnLoop")] 
		public CBool RetriggerAudioOnLoop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("looped")] 
		public CBool Looped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("forceVideoFrameRate")] 
		public CBool ForceVideoFrameRate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("playOnHud")] 
		public CBool PlayOnHud
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("fullScreen")] 
		public CBool FullScreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("useFullscreenVideoState")] 
		public CBool UseFullscreenVideoState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("keepWidescreenAspectRatio")] 
		public CBool KeepWidescreenAspectRatio
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("position")] 
		public Vector2 Position
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(12)] 
		[RED("size")] 
		public Vector2 Size
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public questHUDVideo_NodeType()
		{
			PlayOnHud = true;
			Position = new Vector2();
			Size = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
