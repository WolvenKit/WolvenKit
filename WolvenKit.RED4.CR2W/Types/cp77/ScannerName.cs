using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerName : ScannerChunk
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

		public ScannerName(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
