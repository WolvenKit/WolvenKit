using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UncontrolledMovementEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
