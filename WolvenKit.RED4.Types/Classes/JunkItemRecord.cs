using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JunkItemRecord : RedBaseClass
	{
		private TweakDBID _junkItemID;

		[Ordinal(0)] 
		[RED("junkItemID")] 
		public TweakDBID JunkItemID
		{
			get => GetProperty(ref _junkItemID);
			set => SetProperty(ref _junkItemID, value);
		}
	}
}
