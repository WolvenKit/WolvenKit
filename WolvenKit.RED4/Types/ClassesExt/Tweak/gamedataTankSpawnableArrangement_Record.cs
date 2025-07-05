
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankSpawnableArrangement_Record
	{
		[RED("columnCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 ColumnCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("displacement")]
		[REDProperty(IsIgnored = true)]
		public CName Displacement
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("objectArrangementList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ObjectArrangementList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("probability")]
		[REDProperty(IsIgnored = true)]
		public CFloat Probability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("slot")]
		[REDProperty(IsIgnored = true)]
		public Vector2 Slot
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
	}
}
