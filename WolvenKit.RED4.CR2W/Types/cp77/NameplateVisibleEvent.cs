using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NameplateVisibleEvent : redEvent
	{
		private CBool _isNameplateVisible;
		private entEntityID _entityID;

		[Ordinal(0)] 
		[RED("isNameplateVisible")] 
		public CBool IsNameplateVisible
		{
			get => GetProperty(ref _isNameplateVisible);
			set => SetProperty(ref _isNameplateVisible, value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		public NameplateVisibleEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
