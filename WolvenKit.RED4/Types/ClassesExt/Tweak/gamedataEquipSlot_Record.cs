
namespace WolvenKit.RED4.Types
{
	public partial class gamedataEquipSlot_Record
	{
		[RED("OnInsertion")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> OnInsertion
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("unlockPrereqRecord")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID UnlockPrereqRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("visibleWhenLocked")]
		[REDProperty(IsIgnored = true)]
		public CBool VisibleWhenLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
