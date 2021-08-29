using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePhantomEntityComponent : entIComponent
	{
		private gamePhantomEntityParameters _params;
		private CHandle<gameEffectComponentBinding> _effectBinding;

		[Ordinal(3)] 
		[RED("params")] 
		public gamePhantomEntityParameters Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		[Ordinal(4)] 
		[RED("effectBinding")] 
		public CHandle<gameEffectComponentBinding> EffectBinding
		{
			get => GetProperty(ref _effectBinding);
			set => SetProperty(ref _effectBinding, value);
		}
	}
}
