using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NameplateChangedEvent : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("entity")] 
		public entEntityID Entity
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public NameplateChangedEvent()
		{
			Entity = new();
		}
	}
}
