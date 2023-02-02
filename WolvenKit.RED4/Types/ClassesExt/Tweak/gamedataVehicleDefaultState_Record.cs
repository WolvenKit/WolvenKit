
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleDefaultState_Record
	{
		[RED("CloseAll")]
		[REDProperty(IsIgnored = true)]
		public CBool CloseAll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("DisableAllInteractions")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableAllInteractions
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hood")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Hood
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("LockAll")]
		[REDProperty(IsIgnored = true)]
		public CBool LockAll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("OpenAll")]
		[REDProperty(IsIgnored = true)]
		public CBool OpenAll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("QuestLockAll")]
		[REDProperty(IsIgnored = true)]
		public CBool QuestLockAll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("seat_back_left")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Seat_back_left
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("seat_back_right")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Seat_back_right
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("seat_front_left")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Seat_front_left
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("seat_front_right")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Seat_front_right
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("SirenLight")]
		[REDProperty(IsIgnored = true)]
		public CBool SirenLight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("SirenSounds")]
		[REDProperty(IsIgnored = true)]
		public CBool SirenSounds
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("SpawnDestroyed")]
		[REDProperty(IsIgnored = true)]
		public CBool SpawnDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("Thrusters")]
		[REDProperty(IsIgnored = true)]
		public CBool Thrusters
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("trunk")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Trunk
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
