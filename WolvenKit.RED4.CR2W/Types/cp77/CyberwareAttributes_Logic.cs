using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareAttributes_Logic : inkWidgetLogicController
	{
		private inkTextWidgetReference _textValue;
		private inkWidgetReference _buttonRef;
		private inkWidgetReference _tooltipRef;
		private inkWidgetReference _connectorRef;

		[Ordinal(1)] 
		[RED("textValue")] 
		public inkTextWidgetReference TextValue
		{
			get => GetProperty(ref _textValue);
			set => SetProperty(ref _textValue, value);
		}

		[Ordinal(2)] 
		[RED("buttonRef")] 
		public inkWidgetReference ButtonRef
		{
			get => GetProperty(ref _buttonRef);
			set => SetProperty(ref _buttonRef, value);
		}

		[Ordinal(3)] 
		[RED("tooltipRef")] 
		public inkWidgetReference TooltipRef
		{
			get => GetProperty(ref _tooltipRef);
			set => SetProperty(ref _tooltipRef, value);
		}

		[Ordinal(4)] 
		[RED("connectorRef")] 
		public inkWidgetReference ConnectorRef
		{
			get => GetProperty(ref _connectorRef);
			set => SetProperty(ref _connectorRef, value);
		}

		public CyberwareAttributes_Logic(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
