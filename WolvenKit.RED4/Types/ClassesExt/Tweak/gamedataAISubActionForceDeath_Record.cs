
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionForceDeath_Record
	{
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("hitBodyPart")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitBodyPart
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hitDirection")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hitIntensity")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitIntensity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hitSource")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitSource
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
