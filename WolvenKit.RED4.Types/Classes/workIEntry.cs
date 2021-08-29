using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workIEntry : ISerializable
	{
		private workWorkEntryId _id;
		private CUInt32 _flags;

		[Ordinal(0)] 
		[RED("id")] 
		public workWorkEntryId Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CUInt32 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}
	}
}
