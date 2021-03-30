using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficCompiledNode_ : worldNode
	{
		private Box _aabb;

		[Ordinal(4)] 
		[RED("aabb")] 
		public Box Aabb
		{
			get => GetProperty(ref _aabb);
			set => SetProperty(ref _aabb, value);
		}

		public worldTrafficCompiledNode_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
