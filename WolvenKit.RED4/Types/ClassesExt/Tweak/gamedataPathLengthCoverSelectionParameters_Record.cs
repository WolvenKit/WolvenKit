
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPathLengthCoverSelectionParameters_Record
	{
		[RED("doorInvalidatesPath")]
		[REDProperty(IsIgnored = true)]
		public CBool DoorInvalidatesPath
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("maximumRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaximumRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minPathLengthToPerform")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinPathLengthToPerform
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("multiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("useFriendlyTargetAsStart")]
		[REDProperty(IsIgnored = true)]
		public CBool UseFriendlyTargetAsStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
