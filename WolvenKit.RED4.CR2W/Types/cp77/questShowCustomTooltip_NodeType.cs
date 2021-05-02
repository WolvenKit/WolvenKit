using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShowCustomTooltip_NodeType : questIUIManagerNodeType
	{
		private CBool _setTooltip;
		private LocalizationString _text;
		private CString _inputAction;
		private CEnum<inkInputHintHoldIndicationType> _holdIndicationType;

		[Ordinal(0)] 
		[RED("setTooltip")] 
		public CBool SetTooltip
		{
			get => GetProperty(ref _setTooltip);
			set => SetProperty(ref _setTooltip, value);
		}

		[Ordinal(1)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(2)] 
		[RED("inputAction")] 
		public CString InputAction
		{
			get => GetProperty(ref _inputAction);
			set => SetProperty(ref _inputAction, value);
		}

		[Ordinal(3)] 
		[RED("holdIndicationType")] 
		public CEnum<inkInputHintHoldIndicationType> HoldIndicationType
		{
			get => GetProperty(ref _holdIndicationType);
			set => SetProperty(ref _holdIndicationType, value);
		}

		public questShowCustomTooltip_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
