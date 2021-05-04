using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerDescriptionGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _descriptionText;
		private inkTextWidgetReference _customDescriptionText;
		private CUInt32 _descriptionCallbackID;
		private CBool _isValidDescription;
		private CBool _isValidCustomDescription;

		[Ordinal(5)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(6)] 
		[RED("customDescriptionText")] 
		public inkTextWidgetReference CustomDescriptionText
		{
			get => GetProperty(ref _customDescriptionText);
			set => SetProperty(ref _customDescriptionText, value);
		}

		[Ordinal(7)] 
		[RED("descriptionCallbackID")] 
		public CUInt32 DescriptionCallbackID
		{
			get => GetProperty(ref _descriptionCallbackID);
			set => SetProperty(ref _descriptionCallbackID, value);
		}

		[Ordinal(8)] 
		[RED("isValidDescription")] 
		public CBool IsValidDescription
		{
			get => GetProperty(ref _isValidDescription);
			set => SetProperty(ref _isValidDescription, value);
		}

		[Ordinal(9)] 
		[RED("isValidCustomDescription")] 
		public CBool IsValidCustomDescription
		{
			get => GetProperty(ref _isValidCustomDescription);
			set => SetProperty(ref _isValidCustomDescription, value);
		}

		public ScannerDescriptionGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
