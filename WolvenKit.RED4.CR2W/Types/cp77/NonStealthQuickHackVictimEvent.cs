using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NonStealthQuickHackVictimEvent : redEvent
	{
		private entEntityID _instigatorID;

		[Ordinal(0)] 
		[RED("instigatorID")] 
		public entEntityID InstigatorID
		{
			get => GetProperty(ref _instigatorID);
			set => SetProperty(ref _instigatorID, value);
		}

		public NonStealthQuickHackVictimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
