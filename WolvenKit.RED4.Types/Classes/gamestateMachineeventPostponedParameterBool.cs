using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineeventPostponedParameterBool : gamestateMachineeventPostponedParameterBase
	{
		[Ordinal(2)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
