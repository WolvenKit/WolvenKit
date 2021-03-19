using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetListener : IScriptable
	{
		private CHandle<gamePrereqState> _prereqOwner;

		[Ordinal(0)] 
		[RED("prereqOwner")] 
		public CHandle<gamePrereqState> PrereqOwner
		{
			get => GetProperty(ref _prereqOwner);
			set => SetProperty(ref _prereqOwner, value);
		}

		public PuppetListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
