using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorDrag : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("dragCoefficient")] 
		public CHandle<IEvaluatorFloat> DragCoefficient
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CParticleModificatorDrag()
		{
			EditorName = "Drag";
			IsEnabled = true;
			Scale = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
