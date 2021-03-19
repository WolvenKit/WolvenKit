using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveCommand : AICommand
	{
		private CBool _removeAfterCombat;
		private CBool _ignoreInCombat;
		private CBool _alwaysUseStealth;

		[Ordinal(4)] 
		[RED("removeAfterCombat")] 
		public CBool RemoveAfterCombat
		{
			get => GetProperty(ref _removeAfterCombat);
			set => SetProperty(ref _removeAfterCombat, value);
		}

		[Ordinal(5)] 
		[RED("ignoreInCombat")] 
		public CBool IgnoreInCombat
		{
			get => GetProperty(ref _ignoreInCombat);
			set => SetProperty(ref _ignoreInCombat, value);
		}

		[Ordinal(6)] 
		[RED("alwaysUseStealth")] 
		public CBool AlwaysUseStealth
		{
			get => GetProperty(ref _alwaysUseStealth);
			set => SetProperty(ref _alwaysUseStealth, value);
		}

		public AIMoveCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
