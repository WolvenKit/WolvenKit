using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseSimpleBox : senseIShape
	{
		private Box _box;

		[Ordinal(1)] 
		[RED("box")] 
		public Box Box
		{
			get => GetProperty(ref _box);
			set => SetProperty(ref _box, value);
		}

		public senseSimpleBox(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
