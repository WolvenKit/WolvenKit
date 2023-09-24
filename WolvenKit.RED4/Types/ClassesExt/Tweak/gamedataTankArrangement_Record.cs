
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankArrangement_Record
	{
		[RED("arrangement")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> Arrangement
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("spawnableObjectIDList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SpawnableObjectIDList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("spawnableReplacementObjectCount")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> SpawnableReplacementObjectCount
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("spawnableReplacementObjectIDList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SpawnableReplacementObjectIDList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
