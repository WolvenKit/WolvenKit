using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SCodexRecord : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("RecordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("RecordContent")] 
		public CArray<SCodexRecordPart> RecordContent
		{
			get => GetPropertyValue<CArray<SCodexRecordPart>>();
			set => SetPropertyValue<CArray<SCodexRecordPart>>(value);
		}

		[Ordinal(2)] 
		[RED("Tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("Unlocked")] 
		public CBool Unlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SCodexRecord()
		{
			RecordContent = new();
			Tags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
