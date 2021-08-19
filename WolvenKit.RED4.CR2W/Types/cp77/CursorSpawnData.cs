using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CursorSpawnData : IScriptable
	{
		private CName _cursorType;

		[Ordinal(0)] 
		[RED("cursorType")] 
		public CName CursorType
		{
			get => GetProperty(ref _cursorType);
			set => SetProperty(ref _cursorType, value);
		}

		public CursorSpawnData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
