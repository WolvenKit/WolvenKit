using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MessageThreadReadEvent : redEvent
	{
		private CInt32 _parentHash;

		[Ordinal(0)] 
		[RED("parentHash")] 
		public CInt32 ParentHash
		{
			get => GetProperty(ref _parentHash);
			set => SetProperty(ref _parentHash, value);
		}
	}
}
