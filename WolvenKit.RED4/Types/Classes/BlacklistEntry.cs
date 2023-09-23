using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BlacklistEntry : IScriptable
	{
		[Ordinal(0)] 
		[RED("entryID")] 
		public entEntityID EntryID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("entryReason")] 
		public CEnum<BlacklistReason> EntryReason
		{
			get => GetPropertyValue<CEnum<BlacklistReason>>();
			set => SetPropertyValue<CEnum<BlacklistReason>>(value);
		}

		[Ordinal(2)] 
		[RED("warningsCount")] 
		public CInt32 WarningsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("reprimandID")] 
		public CInt32 ReprimandID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public BlacklistEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
