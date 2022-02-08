using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleInitializerRotation : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("rotation")] 
		public CHandle<IEvaluatorFloat> Rotation
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		public CParticleInitializerRotation()
		{
			EditorName = "Inital rotation";
			EditorGroup = "Rotation";
			IsEnabled = true;
		}
	}
}
