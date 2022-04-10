using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAudioLoadingNodeType : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("banksToLoad")] 
		public CArray<audioSoundBankStruct> BanksToLoad
		{
			get => GetPropertyValue<CArray<audioSoundBankStruct>>();
			set => SetPropertyValue<CArray<audioSoundBankStruct>>(value);
		}

		[Ordinal(1)] 
		[RED("banksToUnload")] 
		public CArray<audioSoundBankStruct> BanksToUnload
		{
			get => GetPropertyValue<CArray<audioSoundBankStruct>>();
			set => SetPropertyValue<CArray<audioSoundBankStruct>>(value);
		}

		[Ordinal(2)] 
		[RED("waitOnLoad")] 
		public CBool WaitOnLoad
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public questAudioLoadingNodeType()
		{
			BanksToLoad = new();
			BanksToUnload = new();
			WaitOnLoad = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
