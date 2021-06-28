using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HeavyFootstepEvent : redEvent
	{
		private wCHandle<gameObject> _instigator;
		private CName _audioEventName;

		[Ordinal(0)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(1)] 
		[RED("audioEventName")] 
		public CName AudioEventName
		{
			get => GetProperty(ref _audioEventName);
			set => SetProperty(ref _audioEventName, value);
		}

		public HeavyFootstepEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
