
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIDirectorScheduleSpawningDesc_Record
	{
		[RED("enemiesAmount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 EnemiesAmount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("entries")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Entries
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("spawningAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpawningAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spawningBigDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpawningBigDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spawningMinDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpawningMinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
