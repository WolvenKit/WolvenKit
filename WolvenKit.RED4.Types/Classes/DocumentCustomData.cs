using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DocumentCustomData : IScriptable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<EDocumentType> Type
		{
			get => GetPropertyValue<CEnum<EDocumentType>>();
			set => SetPropertyValue<CEnum<EDocumentType>>(value);
		}

		public DocumentCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
