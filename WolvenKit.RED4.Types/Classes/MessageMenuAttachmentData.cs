using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MessageMenuAttachmentData : IScriptable
	{
		[Ordinal(0)] 
		[RED("entryHash")] 
		public CInt32 EntryHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
