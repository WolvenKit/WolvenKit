using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workIEntry : ISerializable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public workWorkEntryId Id
		{
			get => GetPropertyValue<workWorkEntryId>();
			set => SetPropertyValue<workWorkEntryId>(value);
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CUInt32 Flags
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
