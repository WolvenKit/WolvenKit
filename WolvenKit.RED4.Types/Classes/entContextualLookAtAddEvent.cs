using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entContextualLookAtAddEvent : entLookAtAddEvent
	{
		private CName _contextName;

		[Ordinal(4)] 
		[RED("contextName")] 
		public CName ContextName
		{
			get => GetProperty(ref _contextName);
			set => SetProperty(ref _contextName, value);
		}
	}
}
