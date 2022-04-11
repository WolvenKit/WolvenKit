using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scneventsDespawnEntityEventParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		public scneventsDespawnEntityEventParams()
		{
			Performer = new() { Id = 4294967040 };
		}
	}
}
