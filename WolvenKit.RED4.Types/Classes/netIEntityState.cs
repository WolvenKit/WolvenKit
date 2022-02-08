using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class netIEntityState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("persistentID")] 
		public CUInt64 PersistentID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}
	}
}
