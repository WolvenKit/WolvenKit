using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetJammedEvent : redEvent
	{
		private CBool _newJammedState;
		private wCHandle<gameweaponObject> _instigator;

		[Ordinal(0)] 
		[RED("newJammedState")] 
		public CBool NewJammedState
		{
			get => GetProperty(ref _newJammedState);
			set => SetProperty(ref _newJammedState, value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public wCHandle<gameweaponObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		public SetJammedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
