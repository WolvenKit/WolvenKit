using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_BoolToFloatConverter : animAnimNode_FloatValue
	{
		private animBoolLink _inputNode;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animBoolLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}
	}
}
