
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSeatState_Record
	{
		[RED("disableInteraction")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("enableInteraction")]
		[REDProperty(IsIgnored = true)]
		public CBool EnableInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("forceClose")]
		[REDProperty(IsIgnored = true)]
		public CBool ForceClose
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("forceLock")]
		[REDProperty(IsIgnored = true)]
		public CBool ForceLock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("forceOpen")]
		[REDProperty(IsIgnored = true)]
		public CBool ForceOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("forceUnlock")]
		[REDProperty(IsIgnored = true)]
		public CBool ForceUnlock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("questLock")]
		[REDProperty(IsIgnored = true)]
		public CBool QuestLock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
