
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPreventionAttackTypeData_Record
	{
		[RED("explosion")]
		[REDProperty(IsIgnored = true)]
		public CFloat Explosion
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("hack")]
		[REDProperty(IsIgnored = true)]
		public CFloat Hack
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("indirect")]
		[REDProperty(IsIgnored = true)]
		public CFloat Indirect
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("kill")]
		[REDProperty(IsIgnored = true)]
		public CFloat Kill
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("melee")]
		[REDProperty(IsIgnored = true)]
		public CFloat Melee
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("ranged")]
		[REDProperty(IsIgnored = true)]
		public CFloat Ranged
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
