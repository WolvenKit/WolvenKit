using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShardAttachmentData : IScriptable
	{
		[Ordinal(0)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ShardAttachmentData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
