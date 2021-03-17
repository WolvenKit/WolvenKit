using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlacklistPeriodEnded : redEvent
	{
		private entEntityID _entityID;

		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		public BlacklistPeriodEnded(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
