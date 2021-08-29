using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatTarget : RedBaseClass
	{
		private CWeakHandle<ScriptedPuppet> _puppet;
		private CBool _hasTime;
		private CFloat _highlightTime;

		[Ordinal(0)] 
		[RED("puppet")] 
		public CWeakHandle<ScriptedPuppet> Puppet
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
	}
}
