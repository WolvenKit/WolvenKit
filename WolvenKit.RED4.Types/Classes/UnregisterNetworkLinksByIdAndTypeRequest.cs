using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterNetworkLinksByIdAndTypeRequest : gameScriptableSystemRequest
	{
		private entEntityID _iD;
		private CEnum<ELinkType> _type;

		[Ordinal(0)] 
		[RED("ID")] 
		public entEntityID ID
		{
			get => GetProperty(ref _iD);
			set => SetProperty(ref _iD, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<ELinkType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
