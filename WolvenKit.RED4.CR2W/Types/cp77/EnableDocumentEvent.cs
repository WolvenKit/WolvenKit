using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EnableDocumentEvent : redEvent
	{
		private CEnum<EDocumentType> _documentType;
		private CName _documentName;
		private SDocumentAdress _documentAdress;
		private CBool _enable;
		private CBool _entireFolder;

		[Ordinal(0)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetProperty(ref _documentType);
			set => SetProperty(ref _documentType, value);
		}

		[Ordinal(1)] 
		[RED("documentName")] 
		public CName DocumentName
		{
			get => GetProperty(ref _documentName);
			set => SetProperty(ref _documentName, value);
		}

		[Ordinal(2)] 
		[RED("documentAdress")] 
		public SDocumentAdress DocumentAdress
		{
			get => GetProperty(ref _documentAdress);
			set => SetProperty(ref _documentAdress, value);
		}

		[Ordinal(3)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(4)] 
		[RED("entireFolder")] 
		public CBool EntireFolder
		{
			get => GetProperty(ref _entireFolder);
			set => SetProperty(ref _entireFolder, value);
		}

		public EnableDocumentEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
