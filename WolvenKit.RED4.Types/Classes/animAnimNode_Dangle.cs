using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_Dangle : animAnimNode_OnePoseInput
	{
		private CHandle<animDangleConstraint_Simulation> _dangleConstraint;

		[Ordinal(12)] 
		[RED("dangleConstraint")] 
		public CHandle<animDangleConstraint_Simulation> DangleConstraint
		{
			get => GetProperty(ref _dangleConstraint);
			set => SetProperty(ref _dangleConstraint, value);
		}
	}
}
