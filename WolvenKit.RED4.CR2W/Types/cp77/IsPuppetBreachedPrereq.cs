using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsPuppetBreachedPrereq : gameIScriptablePrereq
	{
		private CBool _isBreached;

		[Ordinal(0)] 
		[RED("isBreached")] 
		public CBool IsBreached
		{
			get => GetProperty(ref _isBreached);
			set => SetProperty(ref _isBreached, value);
		}

		public IsPuppetBreachedPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
