using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDInstruction : redEvent
	{
		private CHandle<ScanInstance> _scannerInstructions;
		private CHandle<HighlightInstance> _highlightInstructions;
		private CHandle<BraindanceInstance> _braindanceInstructions;
		private CHandle<IconsInstance> _iconsInstruction;
		private CHandle<QuickhackInstance> _quickhackInstruction;

		[Ordinal(0)] 
		[RED("scannerInstructions")] 
		public CHandle<ScanInstance> ScannerInstructions
		{
			get => GetProperty(ref _scannerInstructions);
			set => SetProperty(ref _scannerInstructions, value);
		}

		[Ordinal(1)] 
		[RED("highlightInstructions")] 
		public CHandle<HighlightInstance> HighlightInstructions
		{
			get => GetProperty(ref _highlightInstructions);
			set => SetProperty(ref _highlightInstructions, value);
		}

		[Ordinal(2)] 
		[RED("braindanceInstructions")] 
		public CHandle<BraindanceInstance> BraindanceInstructions
		{
			get => GetProperty(ref _braindanceInstructions);
			set => SetProperty(ref _braindanceInstructions, value);
		}

		[Ordinal(3)] 
		[RED("iconsInstruction")] 
		public CHandle<IconsInstance> IconsInstruction
		{
			get => GetProperty(ref _iconsInstruction);
			set => SetProperty(ref _iconsInstruction, value);
		}

		[Ordinal(4)] 
		[RED("quickhackInstruction")] 
		public CHandle<QuickhackInstance> QuickhackInstruction
		{
			get => GetProperty(ref _quickhackInstruction);
			set => SetProperty(ref _quickhackInstruction, value);
		}

		public HUDInstruction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
