using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerName : ScannerChunk
	{
		private CString _displayName;
		private CBool _hasArchetype;
		private CHandle<textTextParameterSet> _textParams;

		[Ordinal(0)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get => GetProperty(ref _displayName);
			set => SetProperty(ref _displayName, value);
		}

		[Ordinal(1)] 
		[RED("hasArchetype")] 
		public CBool HasArchetype
		{
			get => GetProperty(ref _hasArchetype);
			set => SetProperty(ref _hasArchetype, value);
		}

		[Ordinal(2)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get => GetProperty(ref _textParams);
			set => SetProperty(ref _textParams, value);
		}

		public ScannerName()
		{
			_displayName = new() { Text = "LocKey#42211" };
		}
	}
}
