using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoloDevice : InteractiveDevice
	{
		private CName _questFactName;

		[Ordinal(97)] 
		[RED("questFactName")] 
		public CName QuestFactName
		{
			get => GetProperty(ref _questFactName);
			set => SetProperty(ref _questFactName, value);
		}

		public HoloDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
