using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeStanceStateAbstract : AIbehaviortaskScript
	{
		private CBool _changeStateOnDeactivate;

		[Ordinal(0)] 
		[RED("changeStateOnDeactivate")] 
		public CBool ChangeStateOnDeactivate
		{
			get => GetProperty(ref _changeStateOnDeactivate);
			set => SetProperty(ref _changeStateOnDeactivate, value);
		}

		public ChangeStanceStateAbstract(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
