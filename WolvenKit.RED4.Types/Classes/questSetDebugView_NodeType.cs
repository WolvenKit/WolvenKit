using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetDebugView_NodeType : questIRenderFxManagerNodeType
	{
		private CEnum<questEDebugViewMode> _mode;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<questEDebugViewMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}
	}
}
