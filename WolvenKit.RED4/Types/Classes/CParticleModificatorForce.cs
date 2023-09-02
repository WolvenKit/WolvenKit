using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorForce : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("pivot")] 
		public Vector3 Pivot
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("scale")] 
		public CHandle<IEvaluatorFloat> Scale
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("damp")] 
		public CHandle<IEvaluatorVector> Damp
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		public CParticleModificatorForce()
		{
			EditorName = "Force";
			EditorGroup = "Force";
			IsEnabled = true;
			Pivot = new Vector3();
			Radius = 10.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
