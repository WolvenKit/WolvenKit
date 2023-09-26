
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAimAssistTargetData_Record
	{
		[RED("aimSnapAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat AimSnapAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("aimSnapPriorityWeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat AimSnapPriorityWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("filters")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Filters
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("heightDown")]
		[REDProperty(IsIgnored = true)]
		public CFloat HeightDown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("heightUp")]
		[REDProperty(IsIgnored = true)]
		public CFloat HeightUp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("isForAimMagnetisim")]
		[REDProperty(IsIgnored = true)]
		public CBool IsForAimMagnetisim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isForAimSnap")]
		[REDProperty(IsIgnored = true)]
		public CBool IsForAimSnap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("magnetismPriorityWeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat MagnetismPriorityWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("width")]
		[REDProperty(IsIgnored = true)]
		public CFloat Width
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
