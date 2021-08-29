using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoiceTriggerPerSquadOrderMapItem : RedBaseClass
	{
		private CName _name;
		private CName _triggerName;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("triggerName")] 
		public CName TriggerName
		{
			get => GetProperty(ref _triggerName);
			set => SetProperty(ref _triggerName, value);
		}
	}
}
