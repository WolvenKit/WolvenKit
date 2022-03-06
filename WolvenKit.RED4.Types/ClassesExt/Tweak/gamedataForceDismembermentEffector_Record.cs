
namespace WolvenKit.RED4.Types
{
	public partial class gamedataForceDismembermentEffector_Record
	{
		[RED("bodyPart")]
		[REDProperty(IsIgnored = true)]
		public CString BodyPart
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("dismembermentChance")]
		[REDProperty(IsIgnored = true)]
		public CFloat DismembermentChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("isCritical")]
		[REDProperty(IsIgnored = true)]
		public CBool IsCritical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("shouldKillNPC")]
		[REDProperty(IsIgnored = true)]
		public CBool ShouldKillNPC
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("skipDeathAnim")]
		[REDProperty(IsIgnored = true)]
		public CBool SkipDeathAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("woundType")]
		[REDProperty(IsIgnored = true)]
		public CString WoundType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
