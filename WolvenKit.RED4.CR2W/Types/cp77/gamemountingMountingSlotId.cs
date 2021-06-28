using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingSlotId : CVariable
	{
		private CName _id;

		[Ordinal(0)] 
		[RED("id")] 
		public CName Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public gamemountingMountingSlotId(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
