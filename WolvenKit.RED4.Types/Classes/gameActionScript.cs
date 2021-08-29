using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionScript : gameIObjectScriptBase
	{
		private CUInt32 _actionFlags;

		[Ordinal(1)] 
		[RED("actionFlags")] 
		public CUInt32 ActionFlags
		{
			get => GetProperty(ref _actionFlags);
			set => SetProperty(ref _actionFlags, value);
		}
	}
}
