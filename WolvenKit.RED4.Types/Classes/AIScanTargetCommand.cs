using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIScanTargetCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("targetPuppetRef")] 
		public gameEntityReference TargetPuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public AIScanTargetCommand()
		{
			TargetPuppetRef = new() { Names = new() };
		}
	}
}
