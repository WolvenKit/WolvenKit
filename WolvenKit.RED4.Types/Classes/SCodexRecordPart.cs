using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SCodexRecordPart : RedBaseClass
	{
		private CName _partName;
		private CString _partContent;
		private CBool _unlocked;

		[Ordinal(0)] 
		[RED("PartName")] 
		public CName PartName
		{
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}

		[Ordinal(1)] 
		[RED("PartContent")] 
		public CString PartContent
		{
			get => GetProperty(ref _partContent);
			set => SetProperty(ref _partContent, value);
		}

		[Ordinal(2)] 
		[RED("Unlocked")] 
		public CBool Unlocked
		{
			get => GetProperty(ref _unlocked);
			set => SetProperty(ref _unlocked, value);
		}
	}
}
