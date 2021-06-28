using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeComponent : entIComponent
	{
		private CArray<gameNetrunnerPrototypeStruct> _structs;

		[Ordinal(3)] 
		[RED("structs")] 
		public CArray<gameNetrunnerPrototypeStruct> Structs
		{
			get => GetProperty(ref _structs);
			set => SetProperty(ref _structs, value);
		}

		public gameNetrunnerPrototypeComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
