using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialAreaDespawnEvent : redEvent
	{
		private CName _bracketID;
		private CUInt32 _areaID;

		[Ordinal(0)] 
		[RED("bracketID")] 
		public CName BracketID
		{
			get => GetProperty(ref _bracketID);
			set => SetProperty(ref _bracketID, value);
		}

		[Ordinal(1)] 
		[RED("areaID")] 
		public CUInt32 AreaID
		{
			get => GetProperty(ref _areaID);
			set => SetProperty(ref _areaID, value);
		}

		public gameuiTutorialAreaDespawnEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
