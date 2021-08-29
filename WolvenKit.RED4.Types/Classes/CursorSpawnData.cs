using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CursorSpawnData : IScriptable
	{
		private CName _cursorType;

		[Ordinal(0)] 
		[RED("cursorType")] 
		public CName CursorType
		{
			get => GetProperty(ref _cursorType);
			set => SetProperty(ref _cursorType, value);
		}
	}
}
