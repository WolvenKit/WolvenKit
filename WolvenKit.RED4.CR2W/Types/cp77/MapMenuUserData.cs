using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MapMenuUserData : IScriptable
	{
		private Vector3 _moveTo;

		[Ordinal(0)] 
		[RED("moveTo")] 
		public Vector3 MoveTo
		{
			get => GetProperty(ref _moveTo);
			set => SetProperty(ref _moveTo, value);
		}

		public MapMenuUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
