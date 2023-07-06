using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePlayerSpawnParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isSpectator")] 
		public CBool IsSpectator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("spawnPoint")] 
		public Transform SpawnPoint
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(2)] 
		[RED("recordId")] 
		public TweakDBID RecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("gender")] 
		public CName Gender
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("useSpecifiedStartPoint")] 
		public CBool UseSpecifiedStartPoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("spawnTags")] 
		public redTagList SpawnTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(6)] 
		[RED("nickname")] 
		public CString Nickname
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gamePlayerSpawnParams()
		{
			SpawnPoint = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			SpawnTags = new redTagList { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
