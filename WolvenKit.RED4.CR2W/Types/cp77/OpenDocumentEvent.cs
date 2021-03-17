using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpenDocumentEvent : redEvent
	{
		private CEnum<EDocumentType> _documentType;
		private CName _documentName;
		private SDocumentAdress _documentAdress;
		private CBool _wakeUp;
		private entEntityID _ownerID;

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
		[RED("wakeUp")] 
		public CBool WakeUp
		{
			get => GetProperty(ref _wakeUp);
			set => SetProperty(ref _wakeUp, value);
		}

		[Ordinal(4)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		public OpenDocumentEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
