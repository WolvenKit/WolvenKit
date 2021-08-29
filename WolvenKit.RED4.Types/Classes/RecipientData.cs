using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RecipientData : RedBaseClass
	{
		private CInt32 _fuseID;
		private CInt32 _entryID;

		[Ordinal(0)] 
		[RED("fuseID")] 
		public CInt32 FuseID
		{
			get => GetProperty(ref _fuseID);
			set => SetProperty(ref _fuseID, value);
		}

		[Ordinal(1)] 
		[RED("entryID")] 
		public CInt32 EntryID
		{
			get => GetProperty(ref _entryID);
			set => SetProperty(ref _entryID, value);
		}
	}
}
