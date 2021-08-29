using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SVfxInstanceData : RedBaseClass
	{
		private CHandle<gameFxInstance> _fx;
		private CName _id;

		[Ordinal(0)] 
		[RED("fx")] 
		public CHandle<gameFxInstance> Fx
		{
			get => GetProperty(ref _fx);
			set => SetProperty(ref _fx, value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CName Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}
	}
}
