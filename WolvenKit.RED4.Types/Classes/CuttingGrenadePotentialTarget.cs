using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CuttingGrenadePotentialTarget : RedBaseClass
	{
		private CWeakHandle<ScriptedPuppet> _entity;
		private CInt32 _hits;

		[Ordinal(0)] 
		[RED("entity")] 
		public CWeakHandle<ScriptedPuppet> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(1)] 
		[RED("hits")] 
		public CInt32 Hits
		{
			get => GetProperty(ref _hits);
			set => SetProperty(ref _hits, value);
		}
	}
}
