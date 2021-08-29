using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IEvaluatorVector : IEvaluator
	{
		private CEnum<EFreeVectorAxes> _freeAxes;
		private CBool _spill;

		[Ordinal(0)] 
		[RED("freeAxes")] 
		public CEnum<EFreeVectorAxes> FreeAxes
		{
			get => GetProperty(ref _freeAxes);
			set => SetProperty(ref _freeAxes, value);
		}

		[Ordinal(1)] 
		[RED("spill")] 
		public CBool Spill
		{
			get => GetProperty(ref _spill);
			set => SetProperty(ref _spill, value);
		}
	}
}
