using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CursorSpawnData : IScriptable
	{
		[Ordinal(0)] 
		[RED("cursorType")] 
		public CName CursorType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
