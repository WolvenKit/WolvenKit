
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRoachRaceLevel_Record
	{
		[RED("background")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Background
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("obstacleList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ObstacleList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("obstacleTexturePartMap")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ObstacleTexturePartMap
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("preLoadedResourceList")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> PreLoadedResourceList
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
	}
}
