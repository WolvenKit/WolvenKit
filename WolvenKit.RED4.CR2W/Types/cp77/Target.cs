using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Target : IScriptable
	{
		private wCHandle<gameObject> _target;
		private CBool _isInteresting;
		private CBool _isVisible;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target_
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("isInteresting")] 
		public CBool IsInteresting
		{
			get => GetProperty(ref _isInteresting);
			set => SetProperty(ref _isInteresting, value);
		}

		[Ordinal(2)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}

		public Target(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
