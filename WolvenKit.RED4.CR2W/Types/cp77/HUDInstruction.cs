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
			get
			{
				if (_scannerInstructions == null)
				{
					_scannerInstructions = (CHandle<ScanInstance>) CR2WTypeManager.Create("handle:ScanInstance", "scannerInstructions", cr2w, this);
				}
				return _scannerInstructions;
			}
			set
			{
				if (_scannerInstructions == value)
				{
					return;
				}
				_scannerInstructions = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("highlightInstructions")] 
		public CHandle<HighlightInstance> HighlightInstructions
		{
			get
			{
				if (_highlightInstructions == null)
				{
					_highlightInstructions = (CHandle<HighlightInstance>) CR2WTypeManager.Create("handle:HighlightInstance", "highlightInstructions", cr2w, this);
				}
				return _highlightInstructions;
			}
			set
			{
				if (_highlightInstructions == value)
				{
					return;
				}
				_highlightInstructions = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("braindanceInstructions")] 
		public CHandle<BraindanceInstance> BraindanceInstructions
		{
			get
			{
				if (_braindanceInstructions == null)
				{
					_braindanceInstructions = (CHandle<BraindanceInstance>) CR2WTypeManager.Create("handle:BraindanceInstance", "braindanceInstructions", cr2w, this);
				}
				return _braindanceInstructions;
			}
			set
			{
				if (_braindanceInstructions == value)
				{
					return;
				}
				_braindanceInstructions = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("iconsInstruction")] 
		public CHandle<IconsInstance> IconsInstruction
		{
			get
			{
				if (_iconsInstruction == null)
				{
					_iconsInstruction = (CHandle<IconsInstance>) CR2WTypeManager.Create("handle:IconsInstance", "iconsInstruction", cr2w, this);
				}
				return _iconsInstruction;
			}
			set
			{
				if (_iconsInstruction == value)
				{
					return;
				}
				_iconsInstruction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("quickhackInstruction")] 
		public CHandle<QuickhackInstance> QuickhackInstruction
		{
			get
			{
				if (_quickhackInstruction == null)
				{
					_quickhackInstruction = (CHandle<QuickhackInstance>) CR2WTypeManager.Create("handle:QuickhackInstance", "quickhackInstruction", cr2w, this);
				}
				return _quickhackInstruction;
			}
			set
			{
				if (_quickhackInstruction == value)
				{
					return;
				}
				_quickhackInstruction = value;
				PropertySet(this);
			}
		}

		public HUDInstruction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
