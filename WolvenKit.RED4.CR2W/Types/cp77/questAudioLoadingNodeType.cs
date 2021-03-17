using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioLoadingNodeType : questIAudioNodeType
	{
		private CArray<audioSoundBankStruct> _banksToLoad;
		private CArray<audioSoundBankStruct> _banksToUnload;
		private CBool _waitOnLoad;
		private CString _description;

		[Ordinal(0)] 
		[RED("banksToLoad")] 
		public CArray<audioSoundBankStruct> BanksToLoad
		{
			get => GetProperty(ref _banksToLoad);
			set => SetProperty(ref _banksToLoad, value);
		}

		[Ordinal(1)] 
		[RED("banksToUnload")] 
		public CArray<audioSoundBankStruct> BanksToUnload
		{
			get => GetProperty(ref _banksToUnload);
			set => SetProperty(ref _banksToUnload, value);
		}

		[Ordinal(2)] 
		[RED("waitOnLoad")] 
		public CBool WaitOnLoad
		{
			get => GetProperty(ref _waitOnLoad);
			set => SetProperty(ref _waitOnLoad, value);
		}

		[Ordinal(3)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		public questAudioLoadingNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
