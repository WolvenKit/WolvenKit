using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleInitializerColor : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("color")] 
		public CHandle<IEvaluatorColor> Color
		{
			get => GetPropertyValue<CHandle<IEvaluatorColor>>();
			set => SetPropertyValue<CHandle<IEvaluatorColor>>(value);
		}

		public CParticleInitializerColor()
		{
			EditorName = "Initial color";
			EditorGroup = "Material";
			IsEnabled = true;
		}
	}
}
