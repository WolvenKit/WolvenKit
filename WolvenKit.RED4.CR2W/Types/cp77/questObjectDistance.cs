using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questObjectDistance : questIDistance
	{
		private CBool _isPlayer;
		private gameEntityReference _nodeRef1;
		private gameEntityReference _nodeRef2;

		[Ordinal(0)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(1)] 
		[RED("nodeRef1")] 
		public gameEntityReference NodeRef1
		{
			get => GetProperty(ref _nodeRef1);
			set => SetProperty(ref _nodeRef1, value);
		}

		[Ordinal(2)] 
		[RED("nodeRef2")] 
		public gameEntityReference NodeRef2
		{
			get => GetProperty(ref _nodeRef2);
			set => SetProperty(ref _nodeRef2, value);
		}

		public questObjectDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
