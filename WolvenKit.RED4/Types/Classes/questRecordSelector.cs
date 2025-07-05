using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRecordSelector : ISerializable
	{
		[Ordinal(0)] 
		[RED("isCharacter")] 
		public CBool IsCharacter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("characterRecordID")] 
		public TweakDBID CharacterRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("isDevice")] 
		public CBool IsDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("deviceRecordID")] 
		public TweakDBID DeviceRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("isItem")] 
		public CBool IsItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("itemRecordID")] 
		public TweakDBID ItemRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questRecordSelector()
		{
			IsCharacter = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
