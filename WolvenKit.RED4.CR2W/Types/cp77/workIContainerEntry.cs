using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workIContainerEntry : workIEntry
	{
		private CArray<CHandle<workIEntry>> _list;
		private CName _idleAnim;

		[Ordinal(2)] 
		[RED("list")] 
		public CArray<CHandle<workIEntry>> List
		{
			get => GetProperty(ref _list);
			set => SetProperty(ref _list, value);
		}

		[Ordinal(3)] 
		[RED("idleAnim")] 
		public CName IdleAnim
		{
			get => GetProperty(ref _idleAnim);
			set => SetProperty(ref _idleAnim, value);
		}

		public workIContainerEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
