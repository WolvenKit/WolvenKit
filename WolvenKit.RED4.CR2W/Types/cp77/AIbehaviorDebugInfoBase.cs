using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDebugInfoBase : ISerializable
	{
		private CString _caption;

		[Ordinal(0)] 
		[RED("caption")] 
		public CString Caption
		{
			get => GetProperty(ref _caption);
			set => SetProperty(ref _caption, value);
		}

		public AIbehaviorDebugInfoBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
