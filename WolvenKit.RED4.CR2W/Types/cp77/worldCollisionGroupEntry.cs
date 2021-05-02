using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCollisionGroupEntry : CVariable
	{
		private NodeRef _neRef;
		private CBool _reversed;

		[Ordinal(0)] 
		[RED("neRef")] 
		public NodeRef NeRef
		{
			get => GetProperty(ref _neRef);
			set => SetProperty(ref _neRef, value);
		}

		[Ordinal(1)] 
		[RED("Reversed")] 
		public CBool Reversed
		{
			get => GetProperty(ref _reversed);
			set => SetProperty(ref _reversed, value);
		}

		public worldCollisionGroupEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
