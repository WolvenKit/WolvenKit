using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IParticleEvent : IParticleModule
	{
		[Ordinal(3)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
