using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConstantStatPoolPrereqState : StatPoolPrereqState
	{
		private CBool _listenConstantly;
		private wCHandle<gameObject> _owner;

		[Ordinal(1)] 
		[RED("listenConstantly")] 
		public CBool ListenConstantly
		{
			get => GetProperty(ref _listenConstantly);
			set => SetProperty(ref _listenConstantly, value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public ConstantStatPoolPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
