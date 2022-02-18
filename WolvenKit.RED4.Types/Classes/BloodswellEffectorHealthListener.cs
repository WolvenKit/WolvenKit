using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BloodswellEffectorHealthListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("effector")] 
		public CHandle<BloodswellEffector> Effector
		{
			get => GetPropertyValue<CHandle<BloodswellEffector>>();
			set => SetPropertyValue<CHandle<BloodswellEffector>>(value);
		}
	}
}
