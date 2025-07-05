using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorVectorFieldAttractor : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("inheritVelocity")] 
		public CBool InheritVelocity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("attract")] 
		public CBool Attract
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("drag")] 
		public CBool Drag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("restitution")] 
		public CHandle<IEvaluatorFloat> Restitution
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		public CParticleModificatorVectorFieldAttractor()
		{
			EditorName = "Vector Field Attractor";
			EditorGroup = "Velocity";
			IsEnabled = true;
			InheritVelocity = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
