using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SHitNPC : CVariable
	{
		private entEntityID _entityID;
		private CInt32 _calls;

		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		[Ordinal(1)] 
		[RED("calls")] 
		public CInt32 Calls
		{
			get => GetProperty(ref _calls);
			set => SetProperty(ref _calls, value);
		}

		public SHitNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
