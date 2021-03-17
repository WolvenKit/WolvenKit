using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCrowdNullAreaNode : worldAreaShapeNode
	{
		private CBool _isForBlockade;

		[Ordinal(6)] 
		[RED("IsForBlockade")] 
		public CBool IsForBlockade
		{
			get => GetProperty(ref _isForBlockade);
			set => SetProperty(ref _isForBlockade, value);
		}

		public worldCrowdNullAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
