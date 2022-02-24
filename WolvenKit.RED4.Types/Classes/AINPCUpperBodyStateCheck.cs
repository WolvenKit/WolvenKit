using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AINPCUpperBodyStateCheck : AINPCStateCheck
	{
		[Ordinal(0)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}
	}
}
