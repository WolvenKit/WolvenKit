using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CuttingGrenadePotentialTarget : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entity")] 
		public CWeakHandle<ScriptedPuppet> Entity
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("hits")] 
		public CInt32 Hits
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public CuttingGrenadePotentialTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
