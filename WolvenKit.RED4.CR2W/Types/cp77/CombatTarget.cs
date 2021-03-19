using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatTarget : CVariable
	{
		private wCHandle<ScriptedPuppet> _puppet;
		private CBool _hasTime;
		private CFloat _highlightTime;

		[Ordinal(0)] 
		[RED("puppet")] 
		public wCHandle<ScriptedPuppet> Puppet
		{
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}

		[Ordinal(1)] 
		[RED("hasTime")] 
		public CBool HasTime
		{
			get => GetProperty(ref _hasTime);
			set => SetProperty(ref _hasTime, value);
		}

		[Ordinal(2)] 
		[RED("highlightTime")] 
		public CFloat HighlightTime
		{
			get => GetProperty(ref _highlightTime);
			set => SetProperty(ref _highlightTime, value);
		}

		public CombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
