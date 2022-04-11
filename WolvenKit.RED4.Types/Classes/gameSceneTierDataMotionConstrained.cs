using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSceneTierDataMotionConstrained : gameSceneTierData
	{
		[Ordinal(3)] 
		[RED("params")] 
		public gameMotionConstrainedTierDataParams Params
		{
			get => GetPropertyValue<gameMotionConstrainedTierDataParams>();
			set => SetPropertyValue<gameMotionConstrainedTierDataParams>(value);
		}
	}
}
