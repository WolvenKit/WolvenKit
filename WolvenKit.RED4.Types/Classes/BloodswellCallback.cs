using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BloodswellCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("bloodswellEffector")] 
		public CHandle<BloodswellEffector> BloodswellEffector
		{
			get => GetPropertyValue<CHandle<BloodswellEffector>>();
			set => SetPropertyValue<CHandle<BloodswellEffector>>(value);
		}
	}
}
