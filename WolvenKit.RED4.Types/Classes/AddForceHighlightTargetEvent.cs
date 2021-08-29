using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddForceHighlightTargetEvent : redEvent
	{
		private entEntityID _targetID;
		private CName _effecName;

		[Ordinal(0)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}

		[Ordinal(1)] 
		[RED("effecName")] 
		public CName EffecName
		{
			get => GetProperty(ref _effecName);
			set => SetProperty(ref _effecName, value);
		}
	}
}
