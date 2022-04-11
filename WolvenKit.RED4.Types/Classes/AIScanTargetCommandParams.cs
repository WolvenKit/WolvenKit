using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIScanTargetCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] 
		[RED("targetPuppetRef")] 
		public gameEntityReference TargetPuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public AIScanTargetCommandParams()
		{
			TargetPuppetRef = new() { Names = new() };
		}
	}
}
